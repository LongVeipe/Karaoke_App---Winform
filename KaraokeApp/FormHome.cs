using KaraokeApp.customControl;
using KaraokeApp.data;
using KaraokeApp.userControl;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using Shazam;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace KaraokeApp
{
    public partial class FormHome : Form
    {
        private ObservableCollection<Album> newAlbums;
        private ObservableCollection<string> recentlyMusics;
        private ObservableCollection<string> lovelyMusics;
        private UCRecentlyItem currentMusic;
        private static readonly MMDeviceEnumerator Enumerator = new MMDeviceEnumerator();
        private static readonly HttpClient Http = new HttpClient() { Timeout = TimeSpan.FromSeconds(3) };
        private static readonly string DeviceId = Guid.NewGuid().ToString();

        public static FormHome __instance;
        public static FormHome getInstance()
        {
            if (__instance == null)
                __instance = new FormHome();
            return __instance;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handlerParam = base.CreateParams;
                handlerParam.ExStyle |= 0x02000000;
                return handlerParam;
            }
        }
        public FormHome()
        {
            InitializeComponent();

            newAlbums = Albums.getInstance().GetAlbums();
            recentlyMusics = RecentlyMusics.getInstance().GetAll();
            recentlyMusics.CollectionChanged += RecentlyMusicsChange;

            lovelyMusics = LovelyMusics.getInstance().GetAll();
            lovelyMusics.CollectionChanged += LovelyMusicsChange;

            panelLovely.AutoScroll = panelRecently.AutoScroll = pnlShazamResult.AutoScroll = false;

            panelLovely.VerticalScroll.Maximum = panelRecently.VerticalScroll.Maximum = pnlShazamResult.VerticalScroll.Maximum = 0;
            panelLovely.VerticalScroll.Visible = panelRecently.VerticalScroll.Visible = pnlShazamResult.VerticalScroll.Visible = false;

            panelLovely.AutoScroll = panelRecently.AutoScroll = pnlShazamResult.AutoScroll = true;

            UCSongItem uc = new UCSongItem();
            this.pnlShazamResult.Controls.Add(uc);

        }

        void RecentlyMusicsChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    string path = e.NewItems[0].ToString();
                    UCRecentlyItem uc = new UCRecentlyItem(path);
                    uc.Tag = path;
                    this.panelRecently.Controls.Add(uc);
                    this.panelRecently.Controls.SetChildIndex(uc, 0);
                    break;
                default:
                    break;
            }
        }

        void LovelyMusicsChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    string newItem = e.NewItems[0].ToString();
                    UCLovelyItem uc = new UCLovelyItem(newItem);
                    uc.Tag = newItem;
                    this.panelLovely.Controls.Add(uc);
                    this.panelLovely.Controls.SetChildIndex(uc, 0);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    string oldItem = e.OldItems[0].ToString();
                    ((FormMain)(this.Parent.Parent.Parent.Parent)).RemoveLovelyInQueue(oldItem);
                    RemoveUCLovelyItem(oldItem);
                    break;
                default:
                    break;
            }
        }

        void RemoveUCLovelyItem(string path)
        {
            foreach (Control item in panelLovely.Controls)
            {
                if (item.Tag.ToString() == path)
                {
                    UCLovelyItem uc = (UCLovelyItem)item;
                    uc.Dispose();
                }
            }
        }
        public void PlayRecently(UCRecentlyItem uc)
        {
            if(currentMusic != null)
            {
                currentMusic.PauseMusic();
            }
            currentMusic = uc;
            ((FormMain)(this.Parent.Parent.Parent)).PlayMusic(uc.Tag.ToString());
        
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            foreach (string path in recentlyMusics)
            {
                try
                {
                    UCRecentlyItem uc = new UCRecentlyItem(path);
                    uc.Tag = path;
                    this.panelRecently.Controls.Add(uc);
                }
                catch
                {

                }
            }
        }

        private async void btnRecord_Click(object sender, EventArgs e)
        {

        }
        public static async Task<ShazamMatch> IdentifyAsync(string deviceId, CancellationToken cancel)
        {
            var device = Enumerator.GetDevice(deviceId);
            if (device == null || device.State != DeviceState.Active) throw new ArgumentException("Selected device not available");

            var capture = device.DataFlow == DataFlow.Capture ? new WasapiCapture(device) : new WasapiLoopbackCapture(device);

            var buffer = new BufferedWaveProvider(capture.WaveFormat) { ReadFully = false, DiscardOnBufferOverflow = true };
            var resampler = new MediaFoundationResampler(buffer, new WaveFormat(16000, 16, 1));
            var samples = resampler.ToSampleProvider();

            capture.DataAvailable += (_, e) => { buffer.AddSamples(e.Buffer, 0, e.BytesRecorded); };
            capture.StartRecording();

            var analyser = new Analyser();
            var landmarker = new Landmarker(analyser);

            var retryMs = 3000;

            while (true)
            {
                if (cancel.IsCancellationRequested)
                {
                    capture.StopRecording();
                    throw new OperationCanceledException();
                }

                if (buffer.BufferedDuration.TotalSeconds < 1)
                {
                    Thread.Sleep(100);
                    continue;
                }

                analyser.ReadChunk(samples);

                if (analyser.StripeCount > 2 * Landmarker.RADIUS_TIME) landmarker.Find(analyser.StripeCount - Landmarker.RADIUS_TIME - 1);
                if (analyser.ProcessedMs < retryMs) continue;

                var body = new ShazamRequest
                {
                    Signature = new ShazamSignature
                    {
                        Uri = "data:audio/vnd.shazam.sig;base64," + Convert.ToBase64String(Signature.Create(Analyser.SAMPLE_RATE, analyser.ProcessedSamples, landmarker)),
                        SampleMs = analyser.ProcessedMs
                    }
                };

                var res = await Http.PostAsync($"https://amp.shazam.com/discovery/v5/en/US/android/-/tag/{DeviceId}/{Guid.NewGuid()}", new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json"), cancel);
                if (cancel.IsCancellationRequested || !res.IsSuccessStatusCode)
                    return null;

                var data = JsonSerializer.Deserialize<ShazamResponse>(await res.Content.ReadAsStringAsync());

                if (data.RetryMs > 0)
                {
                    retryMs = (int)data.RetryMs;
                    continue;
                }

                capture.StopRecording();
                if (data.Track == null) return null;
                return new ShazamMatch
                {
                    Title = data.Track.Title,
                    Artist = data.Track.Subtitle,
                    Link = data.Track.Share.Link,
                    Cover = data.Track?.Images?.CoverHQ ?? data.Track?.Images?.Cover ?? data.Track.Share.Image
                };
            }
        }
    }
}
