using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using KaraokeApp.data;
using KaraokeApp.userControl;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace KaraokeApp
{
    public partial class FormMain : Form
    {

        private Guna2CircleButton currentBtn;
        private Form currentChildForm;
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public FormMain()
        {
            InitializeComponent();

            OpenChildForm(FormHome.getInstance());
            DataPool.Player = this.player;

            panelQueue.AutoScroll = false;

            panelQueue.VerticalScroll.Maximum = 0;
            panelQueue.VerticalScroll.Visible = false;
            panelQueue.HorizontalScroll.Maximum = 0;
            panelQueue.HorizontalScroll.Visible = false;

            panelQueue.AutoScroll = true;

        }


        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                this.currentChildForm.Hide();
            }

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            if(panelChildForm.Controls.IndexOf(childForm) < 0)
                panelChildForm.Controls.Add(childForm);
            //childForm.Parent = this;
            //panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            if(currentBtn != null)
                currentBtn.Checked = false;
            currentBtn = (Guna2CircleButton)sender;
            currentBtn.Checked = true;

            labelScreenName.Text = currentBtn.Tag.ToString();
            switch(currentBtn.Tag.ToString())
            {
                case "Home":
                    OpenChildForm(FormHome.getInstance());
                    break;
                case "Settings":
                    OpenChildForm(FormSettings.getInstance());
                    break;
            }
        }

        public void PlayMusic(string newPath="")
        {
            if (newPath == player.URL)
                return;
            else if (newPath != "")
            {
                ShowPlayingInfo(newPath);
                player.URL = newPath;
            }
            string fileName = Path.GetFileNameWithoutExtension(newPath);
            // Update Current Song
            Song newSong = new Song(fileName, newPath);
            DataPool.UpdateCurrentSong(newSong);
            player.Ctlcontrols.play();
            buttonPlay.Image = Properties.Resources.icons8_pause_button_48;

        }

        public void RemoveLovelyInQueue(string path)
        {
            foreach(Control item in panelQueue.Controls)
            {
                if (item.Tag.ToString() == path)
                {
                    UCQueueItem uc = (UCQueueItem)item;
                    uc.UnCheckedLovely();
                }
            }
        }

        void PauseMusic()
        {
            player.Ctlcontrols.pause();
            buttonPlay.Image = Properties.Resources.icons8_circled_play_48;
            if(currentChildForm is FormPlayer)
            {
                ((FormPlayer)currentChildForm).PauseLyric();
            }
        }

        void RepeatMusic()
        {
            player.Ctlcontrols.currentPosition = trackBar.Value = 0;
        }

        Bitmap GetMp3Artwork(TagLib.File file)
        {
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            else
            {
                // TODO: set "no cover" image
                return null;
            }
        }
        void ShowPlayingInfo(string path)
        {
            string artist = "Unknown", title = "Unknown";

            TagLib.File file = TagLib.File.Create(path);
            string[] artists = file.Tag.Performers;
            artist = artists.Length > 0 ? artists.FirstOrDefault() : "Unknown";
            title = file.Tag.Title != null? file.Tag.Title: "Unknown";

            labelPlayingTitle.Text = title;
            labelPlayingArtist.Text = artist;
            pictureBoxPlayingArtwork.Image = GetMp3Artwork(file);
        }

        void LoadQueue(string[] fileNames)
        {
            panelQueue.Controls.Clear();
                
            foreach (string fileName in fileNames)
            {
                Queue.getInstance().Add(fileName);
                UCQueueItem uc = new UCQueueItem(fileName);
                uc.Tag = fileName;
                uc.Name = fileName;
                uc.Dock = DockStyle.Top;
                panelQueue.Controls.Add(uc);
                panelQueue.Controls.SetChildIndex(uc, 0);
            }
        }

        int randomQueue()
        {
            ObservableCollection<QueueItem> q = Queue.getInstance().GetAll();

            Random r = new Random();
            return r.Next(0, q.Count);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActivateButton(this.buttonHome, e);
        }

        private void buttonLyric_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, e);
            FormPlayer formPlayer = new FormPlayer();

            OpenChildForm(formPlayer);
            formPlayer.UpdateLyric(trackBar.Value);
            
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                LoadQueue(ofd.FileNames);
                PlayMusic(ofd.FileName);
                RecentlyMusics.getInstance().Add(ofd.FileName);
                if(currentChildForm is FormPlayer)
                {
                    ((FormPlayer)currentChildForm).ChangeSong();
                }
            }

            List<Album> albs = new List<Album>();
            foreach(string fp in ofd.FileNames)
            {
                TagLib.File file = TagLib.File.Create(fp);
                albs.Add(new Album(file.Tag.Album, string.Join(", ", file.Tag.AlbumArtists), GetMp3Artwork(file)));
            }
            Albums.getInstance().AddData(albs);
            //FormHome.getInstance().LoadAlbums();
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                trackBar.Value = (int)player.Ctlcontrols.currentPosition;
            }

            //Console.WriteLine(trackBar.Value + "/" + trackBar.Maximum);
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            buttonRepeat.Checked = !buttonRepeat.Checked;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(player.Ctlcontrols.currentItem != null)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    PauseMusic();

                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    PlayMusic();
                    if(currentChildForm is FormPlayer)
                    {
                        ((FormPlayer)currentChildForm).ContinueLyric(trackBar.Value);
                    }
                }
            }
        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (player.Ctlcontrols.currentItem == null)
                trackBar.Value = 0;
            player.Ctlcontrols.currentPosition = trackBar.Value;
            

            if(currentChildForm is FormPlayer)
            {
                ((FormPlayer)currentChildForm).UpdateLyric(trackBar.Value * 1000);
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar.Value >= trackBar.Maximum && buttonRepeat.Checked && player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                RepeatMusic();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ObservableCollection<QueueItem> q = Queue.getInstance().GetAll();
            if (q.Count == 0)
                return;
            string newPath = "";
            if (this.buttonShuffle.Checked)
            {
                newPath = q[randomQueue()].GetMusicPath();
            }
            else
            {
                int currentMusicId = q.Where(x => x.GetMusicPath() == player.URL).First().getId();

                if (currentMusicId == q.Count - 1)
                    return;
                newPath = q[currentMusicId + 1].GetMusicPath();
            }
            PlayMusic(newPath);
            RecentlyMusics.getInstance().Add(newPath);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ObservableCollection<QueueItem> q = Queue.getInstance().GetAll();
            if (q.Count == 0)
                return;
            int currentMusicId = q.Where(x => x.GetMusicPath() == player.URL).First().getId();

            if (currentMusicId == 0)
                return;
            string newPath = q[currentMusicId -1].GetMusicPath();
            PlayMusic(newPath);
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            this.buttonShuffle.Checked = !buttonShuffle.Checked;
        }
    }
}
