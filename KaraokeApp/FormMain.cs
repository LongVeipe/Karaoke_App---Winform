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

namespace KaraokeApp
{
    public partial class FormMain : Form
    {
        private const int C_GRIP = 16;
        private const int C_CAPTION = 32;

        private Guna2CircleButton currentBtn;
        private Form currentChildForm;
        

        public FormMain()
        {
            InitializeComponent();

            OpenChildForm(new FormHome());
            DataPool.Player = this.player;
            //LyricUtil.ReadLRCFile("./ZO0AZO7E.lrc");
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
            panelChildForm.Controls.Add(childForm);
            //childForm.Parent = this;
            //panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object sender)
        {
            if (sender == null)
                return;

            if(currentBtn != null)
                currentBtn.Checked = false;
            currentBtn = (Guna2CircleButton)sender;
            currentBtn.Checked = true;

            labelScreenName.Text = currentBtn.Tag.ToString();
        }

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

        public void PlayMusic(string newPath="")
        {
            if (newPath == player.URL)
                return;
            else if (newPath != "")
            {
                ShowPlayingInfo(newPath);
                player.URL = newPath;
            }
            player.Ctlcontrols.play();
            //buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            buttonPlay.Image = Properties.Resources.icons8_pause_button_48;

        }

        void PauseMusic()
        {
            player.Ctlcontrols.pause();
            //buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
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
                // set "no cover" image
                return null;
            }
        }
        void ShowPlayingInfo(string path)
        {
            string artist = "Unknown", title = "Unknown";

            TagLib.File file = TagLib.File.Create(path);
            string[] artists = file.Tag.Artists;
            artist = artists.Length > 0 ? artists.FirstOrDefault() : "Unknown";
            title = file.Tag.Title != null? file.Tag.Title: "Unknown";

            labelPlayingTitle.Text = title;
            labelPlayingArtist.Text = artist;
            pictureBoxPlayingArtwork.Image = GetMp3Artwork(file);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActivateButton(this.buttonHome);
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonFavorite_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonPlayList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonLyric_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormPlayer formPlayer = new FormPlayer();

            OpenChildForm(formPlayer);
            formPlayer.UpdateLyric(trackBar.Value);
            
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            //DragForm(sender, e);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                PlayMusic(ofd.FileName);
                RecentlyMusics.getInstant().Add(ofd.FileName);

                // Update Current Song
                Song newSong = new Song(labelPlayingTitle.Text, ofd.FileName);
                DataPool.UpdateCurrentSong(newSong);
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

       
    }
}
