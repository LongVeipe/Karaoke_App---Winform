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
        private UCQueueItem currentQueueItem;
        private Form currentChildForm;

        #region CustomForm
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
        #endregion

        public static Color clrBackgroundDark = Color.FromArgb(22, 23, 40);
        public static Color clrPanelDark = Color.FromArgb(35, 38, 62);
        public static Color clrCardDark = Color.FromArgb(39, 40, 71);
        public static Color clrBackgroundLight = Color.Azure;
        public static Color clrPanelLight = Color.SeaGreen;
        public static Color clrCardLight = Color.MediumSeaGreen;

        public bool isDark = true;
        public bool isEnglish = true;
        public FormMain()
        {
            InitializeComponent();

            OpenChildForm(new FormHome(this));
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
                this.currentChildForm.Close();
                this.currentChildForm.Dispose();
            }

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            SwitchMode();
            SwitchLanguage();

            if (panelChildForm.Controls.IndexOf(childForm) < 0)
                panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            if (currentBtn != null)
                currentBtn.Checked = false;
            currentBtn = (Guna2CircleButton)sender;
            currentBtn.Checked = true;

            labelScreenName.Text = currentBtn.Tag.ToString();
            switch (currentBtn.Tag.ToString())
            {
                case "Home":
                    OpenChildForm( new FormHome(this));
                    break;
                case "List":
                    OpenChildForm(new FormList());
                    break;
                case "Lyric":
                    FormPlayer formPlayer = new FormPlayer();
                    OpenChildForm(formPlayer);
                    formPlayer.UpdateLyric(trackBar.Value);
                    break;
            }

        }

        public void PlayMusic(string newPath = "")
        {
            if (newPath == player.URL)
                return;
            else if (newPath != "")
            {
                ShowPlayingInfo(newPath);
                player.URL = newPath;
                string fileName = Path.GetFileNameWithoutExtension(newPath);
                // Update Current Song
                Song newSong = new Song(fileName, newPath);
                DataPool.UpdateCurrentSong(newSong);
            }

            player.Ctlcontrols.play();
            //buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            buttonPlay.Image = Properties.Resources.icons8_pause_button_48;

        }


        public void PlaySong(Song _song)
        {
            if (_song != null)
            {
                string absoulutePath = Path.GetFullPath(_song.GetStreamLink());
                if (absoulutePath == player.URL)
                    return;
                else if (absoulutePath != "")
                {
                    ShowPlayingInfo(absoulutePath);
                    player.URL = absoulutePath;
                    DataPool.UpdateCurrentSong(_song);
                }
                player.Ctlcontrols.play();
                buttonPlay.Image = Properties.Resources.icons8_pause_button_48;
            }

        }
        public void PlayMusicInDB(string newPath = "")
        {
            if (newPath == player.URL)
                return;
            else if (newPath != "")
            {
                ShowPlayingInfo(newPath);
                player.URL = newPath;
            }
            player.Ctlcontrols.play();
            buttonPlay.Image = Properties.Resources.icons8_pause_button_48;
        }


        public void PlayingKaraoke()
        {
            Song _currentSong = DataPool.GetCurrentSong();
            string absoluteBeatPath = Path.GetFullPath(_currentSong.GetBeatLink());

            DataPool.ClearQueue();
            this.UpdatePanelQueue();

            if (absoluteBeatPath == player.URL)
                return;
            else if (absoluteBeatPath != "")
            {
                ShowPlayingInfo(_currentSong.GetStreamLink());
                player.URL = absoluteBeatPath;
            }
            buttonPlay.Image = Properties.Resources.icons8_pause_button_48;

            DialogResult result = MessageBox.Show("Bạn có muốn chuyển qua Karaoke Mode ?",
                "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                buttonLyric.PerformClick();
            }
        }

        public void UpdatePanelQueue()
        {
            panelQueue.Controls.Clear();
            foreach(Song songIndex in DataPool.GetQueue())
            {
                UCQueueItem uc = new UCQueueItem(songIndex);
                uc.Tag = songIndex.GetStreamLink();
                uc.Name = songIndex.GetTitle();
                uc.Dock = DockStyle.Top;
                panelQueue.Controls.Add(uc);
                panelQueue.Controls.SetChildIndex(uc, 0);
            }
        }
        public void RemoveLovelyInQueue(string path)
        {
            foreach (Control item in panelQueue.Controls)
            {
                UCQueueItem queueItem = ((UCQueueItem)item);
                if (queueItem.GetStreamPath() == path)
                {
                    queueItem.UnCheckedLovely();
                }
            }
        }

        public void PauseMusic()
        {
            player.Ctlcontrols.pause();
            buttonPlay.Image = Properties.Resources.icons8_circled_play_48;
            if (currentChildForm is FormPlayer)
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
            title = file.Tag.Title != null ? file.Tag.Title : "Unknown";

            labelPlayingTitle.Text = title;
            labelPlayingArtist.Text = artist;
            pictureBoxPlayingArtwork.Image = GetMp3Artwork(file);
        }

        void LoadQueue(string[] fileNames)
        {
            panelQueue.Controls.Clear();
            DataPool.ClearQueue();

            foreach (string fileName in fileNames)
            {
                Song queueSong = DataPool.SearchInSongList(fileName);
                if (queueSong == null)
                {
                    string name = Path.GetFileNameWithoutExtension(fileName);
                    queueSong = new Song(name, fileName);
                    DatabaseHelper.SaveSong(queueSong);
                }
                DataPool.InsertToQueue(queueSong);
                UCQueueItem uc = new UCQueueItem(queueSong);
                uc.Tag = fileName;
                uc.Name = fileName;
                uc.Dock = DockStyle.Top;
                panelQueue.Controls.Add(uc);
                panelQueue.Controls.SetChildIndex(uc, 0);
            }
        }

        int randomQueue()
        {
            Random r = new Random();
            return r.Next(0, DataPool.GetQueue().Count);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActivateButton(this.buttonHome, e);
        }

        public void AddQueueItem(Song _songItem)
        {
            
            DataPool.InsertToQueue(_songItem);
            UCQueueItem queueItem = new UCQueueItem(_songItem);
            queueItem.Dock = DockStyle.Top;
            panelQueue.Controls.Add(queueItem);

            if(DataPool.GetQueue().Count == 1)
            {
                PlaySong(_songItem);
                DataPool.InsertToRecentlyPlayedList(_songItem);
            }

        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadQueue(ofd.FileNames);
                Song _song = DataPool.GetQueue()[0];
                PlaySong(_song);
                DataPool.InsertToRecentlyPlayedList(_song);

                if (currentChildForm is FormPlayer)
                {
                    ((FormPlayer)currentChildForm).ChangeSong();
                }
            }

            List<Album> albs = new List<Album>();
            foreach (string fp in ofd.FileNames)
            {
                TagLib.File file = TagLib.File.Create(fp);
                albs.Add(new Album(file.Tag.Album, string.Join(", ", file.Tag.AlbumArtists), GetMp3Artwork(file)));
            }
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
            if (player.Ctlcontrols.currentItem != null)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    PauseMusic();

                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    PlayMusic();
                    if (currentChildForm is FormPlayer)
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


            if (currentChildForm is FormPlayer)
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
            List<Song> _queue = DataPool.GetQueue();
            if (_queue.Count == 0)
                return;
            Song nextSong = null;
            if (this.buttonShuffle.Checked)
            {
                nextSong = _queue[randomQueue()];
            }
            else
            {
                int currentMusicId = _queue.IndexOf(DataPool.GetCurrentSong());

                if (currentMusicId == _queue.Count - 1)
                    return;
                nextSong = _queue[currentMusicId + 1];
            }
            PlaySong(nextSong);


            if (currentChildForm is FormPlayer)
            {
                ((FormPlayer)currentChildForm).ChangeSong();
            }

            DataPool.InsertToRecentlyPlayedList(nextSong);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ObservableCollection<QueueItem> q = Queue.getInstance().GetAll();
            List<Song> _queue = DataPool.GetQueue();
            if (_queue.Count == 0)
                return;
            int currentMusicId = _queue.IndexOf(DataPool.GetCurrentSong());

            if (currentMusicId == 0)
                return;
            Song preSong = _queue[currentMusicId -  1];
            PlaySong(preSong);
            if (currentChildForm is FormPlayer)
            {
                ((FormPlayer)currentChildForm).ChangeSong();
            }
        }

        public void PlayQueueItem(UCQueueItem queueItem)
        {
            PlaySong(queueItem.GetSongItem());
            foreach(Control item in panelQueue.Controls)
            {
                UCQueueItem _queueItem = (UCQueueItem)item;
                _queueItem.NotPlayYet();
            }
            queueItem.IsPlaying();
            if (currentChildForm is FormPlayer)
            {
                ((FormPlayer)currentChildForm).ChangeSong();
            }

            if(DataPool.InsertToRecentlyPlayedList(queueItem.GetSongItem()))
            {
                if(currentChildForm is FormHome)
                {
                    ((FormHome)currentChildForm).UpdateCurrentRecently();
                }
            }
        }
        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            this.buttonShuffle.Checked = !buttonShuffle.Checked;
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            
            this.BackColor =  btnDark.Checked ? clrBackgroundDark : clrBackgroundLight;
            labelScreenName.ForeColor = !btnDark.Checked ? clrBackgroundDark : clrBackgroundLight;
            pnlNav.BackColor = panelPlaying.BackColor = btnDark.Checked ? clrPanelDark : clrPanelLight;
            pnlLine.FillColor = btnDark.Checked ? Color.FromArgb(45, 48, 75) : Color.Green;

            isDark = btnDark.Checked;

            btnDark.Checked = !btnDark.Checked;
            SwitchMode();

        }

        public void SwitchMode()
        {
            switch (labelScreenName.Text)
            {
                case "Home":
                    ((FormHome)this.currentChildForm).SwitchMode(isDark);
                    break;
                case "List":
                    ((FormList)this.currentChildForm).SwitchMode(isDark);
                    break;
                case "Lyric":
                    ((FormPlayer)this.currentChildForm).SwitchMode(isDark);
                    break;
            }
        }

        public void SwitchLanguage()
        {
            if (!isEnglish)
            {
                lblPlaying.Text = "Đang Phát";
                lblQueue.Text = "Danh Sách";
                switch (labelScreenName.Text)
                {
                    case "Home":
                        labelScreenName.Text = "Trang Chủ";
                        ((FormHome)this.currentChildForm).SwitchLanguage(false);
                        break;
                    case "List":
                        labelScreenName.Text = "Danh Sách";
                        break;
                    case "Lyric":
                        labelScreenName.Text = "Lời Nhạc";
                        ((FormPlayer)this.currentChildForm).SwitchLanguage(false);
                        break;
                }
            }
            else
            {
                lblPlaying.Text = "Playing";
                lblQueue.Text = "Queue";
                switch (labelScreenName.Text)
                {
                    case "Trang Chủ":
                        labelScreenName.Text = "Home";
                        ((FormHome)this.currentChildForm).SwitchLanguage(true);
                        break;
                    case "Danh Sách":
                        labelScreenName.Text = "List";
                        break;
                    case "Lời Nhạc":
                        labelScreenName.Text = "Lyric";
                        ((FormPlayer)this.currentChildForm).SwitchLanguage(true);
                        break;
                }
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            isEnglish = btnLanguage.Checked;
            SwitchLanguage();
            btnLanguage.Checked = !btnLanguage.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
