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
        private const int C_GRIP = 16;
        private const int C_CAPTION = 32;

        private Guna2CircleButton currentBtn;
        private Form currentChildForm;
        private QueueItem currentMusic;

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void DragForm(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
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
            if (panelChildForm.Controls.IndexOf(childForm) < 0)
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

            if (currentBtn != null)
                currentBtn.Checked = false;
            currentBtn = (Guna2CircleButton)sender;
            currentBtn.Checked = true;

            labelScreenName.Text = currentBtn.Tag.ToString();
            switch (currentBtn.Tag.ToString())
            {
                case "Search":
                    OpenChildForm(FormSearch.getInstance());
                    break;
                case "Home":
                    OpenChildForm( new FormHome(this));
                    break;
                case "Settings":
                    OpenChildForm(FormSettings.getInstance());
                    break;
                case "List":
                    OpenChildForm(new FormList());
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

        private void buttonLyric_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, e);
            FormPlayer formPlayer = new FormPlayer();

            OpenChildForm(formPlayer);
            formPlayer.UpdateLyric(trackBar.Value);

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            //DragForm(sender, e);
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
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            this.buttonShuffle.Checked = !buttonShuffle.Checked;
        }
    }
}
