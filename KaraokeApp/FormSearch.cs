using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaraokeApp.userControl;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using Shazam;


namespace KaraokeApp
{
    public partial class FormSearch : Form
    {
        private static readonly MMDeviceEnumerator Enumerator = new MMDeviceEnumerator();
        private static readonly HttpClient Http = new HttpClient() { Timeout = TimeSpan.FromSeconds(3) };
		private static readonly string DeviceId = Guid.NewGuid().ToString();
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams handlerParam = base.CreateParams;
				handlerParam.ExStyle |= 0x02000000;
				return handlerParam;
			}
		}
		public FormSearch()
        {
            InitializeComponent();
			pnlShazamResult.AutoScroll = false;

			pnlShazamResult.VerticalScroll.Maximum = 0;
			pnlShazamResult.VerticalScroll.Visible = false;

			pnlShazamResult.AutoScroll = true;
		}

		private async void btnRecord_Click(object sender, EventArgs e)
        {
			if (btnRecord.Checked) return;
				btnRecord.Checked = true;
			var timer = new System.Timers.Timer(500);
			timer.Start();

			try
			{
				var tmp = Enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active).Select(device => {
					return new Device(device.ID, device.FriendlyName);
				}).ToList();

				var cancel = new CancellationTokenSource();

                Task.Delay(15000).ContinueWith((_) => { cancel.Cancel(); });

                var match = await Task.Run(() => IdentifyAsync(tmp[0].DeviceId, cancel.Token));
				if (match != null)
				{
					UCSongItem uc = new UCSongItem();
					await uc.SetPropertiesAsync(match);
					this.pnlShazamResult.Controls.Add(uc);
					this.pnlShazamResult.Controls.SetChildIndex(uc, 0);
				}
				else
					MessageBox.Show("No Song Matched");
			}
			catch
			{
				throw ;
			}
			btnRecord.Checked = false;
			timer.Stop();
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
