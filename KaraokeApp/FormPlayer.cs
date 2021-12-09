using KaraokeApp.data;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class FormPlayer : Form
    {
        // Use for zoom animation
        //private int scale = 0;
        private const int MAXIMUMSCALE = 50;
        private Timer timer = new Timer();
        private List<Bitmap> backgroundList;
        private int currentIndex = 0;
        private Recorder _record = null;

        private const string BEAT_PATH = "../../Resources/beat/";
        private const string BACKGROUND_PATH = "../../Resources/Background_Karaoke/";
        private bool karaokeMode = false;
        public FormPlayer()
        {
            InitializeComponent();
            DoubleBuffered = true;
            AddBackgroundImage();
            // 1 frame every 100ms
            this.DoubleBuffered = true;
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            pnlRecord.Visible = false;
            //timer.Start();

            //backgroundPanel.Paint += new PaintEventHandler(BackGround_Pait);
        }


        /* private void BackGround_Pait(object sender, PaintEventArgs e)
         {
             Graphics grap = e.Graphics;
             Bitmap bmp = new Bitmap(backgroundList[currentIndex],
                  backgroundList[currentIndex].Width +
                 (backgroundList[currentIndex].Width * scale / 100),
                 backgroundList[currentIndex].Height +
                 (backgroundList[currentIndex].Height + scale / 100));
             grap.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
             grap.DrawImage(bmp, 0, 0, backgroundPanel.Width, backgroundPanel.Height);
         }*/
        private void AddBackgroundImage()
        {
            backgroundList = new List<Bitmap>();
            string[] filePaths = Directory.GetFiles(BACKGROUND_PATH,
                "*.jpg");
            foreach (string index in filePaths)
            {
                backgroundList.Add(new Bitmap(index));
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (karaokeMode == true)
            {
                currentIndex++;
                if (currentIndex > backgroundList.Count - 1)
                    currentIndex = 0;
                backgroundPanel.BackgroundImage = backgroundList[currentIndex];


                /*   scale+=10;
                   if(scale > MAXIMUMSCALE)
                   {
                       scale = 1;
                       currentIndex++;
                       if (currentIndex > backgroundList.Count - 1)
                           currentIndex = 0;
                   }*/
                Invalidate();

            }
        }

        public void ChangeSong()
        {
            this.lyricViewPanel.UpdateLyricList();
        }
        public void UpdateLyric(double ms)
        {
            if (DataPool.GetCurrentSong() != null)
                lyricViewPanel.UpdateToCurrentPosition(ms);
        }

        public void PauseLyric()
        {
            lyricViewPanel.PauseLyric();
        }

        public void ContinueLyric(double ms)
        {
            lyricViewPanel.UpdateToCurrentPosition(ms);
            lyricViewPanel.ContinueLyric();
        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {
            if (DataPool.GetCurrentSong() != null)
            {
                string currentSongName = DataPool.GetCurrentSong().GetName();
                OpenBeatFile(BEAT_PATH + currentSongName + ".m4a");
                karaokeMode = true;
                backgroundPanel.BackgroundImage = backgroundList[0];
                btnKaraoke.Enabled = false;
                btnLyric.Enabled = true;
                pnlRecord.Visible = true;
            }
        }

        private void btnLyric_Click(object sender, EventArgs e)
        {

            if (DataPool.GetCurrentSong() != null)
            {
                karaokeMode = false;
                btnKaraoke.Enabled = true;
                btnLyric.Enabled = false;
                timer.Stop();
                OpenStreamFile(DataPool.GetCurrentSong().GetStreamLink());
                lyricViewPanel.SwitchToLyricMode();
                pnlRecord.Visible = false;
            }

        }


        private void OpenBeatFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string absolutePath = Path.GetFullPath(filePath);
                DataPool.Player.URL = absolutePath;
                DataPool.Player.Ctlcontrols.play();
                lyricViewPanel.UpdateToCurrentPosition(0);
                lyricViewPanel.SwitchToKaraokeMode();
                timer.Start();
            }
            else
            {
                MessageBox.Show("Bài hát không hỗ trợ Kara!");
            }
        }

        private void OpenStreamFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string absolutePath = Path.GetFullPath(filePath);
                DataPool.Player.URL = absolutePath;
                DataPool.Player.Ctlcontrols.play();
                lyricViewPanel.UpdateToCurrentPosition(0);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

            if (btnRecord.Checked)
            {
                btnRecord.Checked = false;
                if(_record.isPaused == false)
                {
                    _record.PauseRecording();
                }

            }
            else
            {
                btnRecord.Checked = true;
                if (_record == null)
                {
                    _record = new Recorder("../../Resources/record/", "1.wav", 0);
                    _record.StartRecording();
                }
                else if (_record.isPaused == true)
                {
                    _record.ResumeRecording();
                
                }   
            }
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            if(btnRecord.Checked)
            {
                btnRecord.Checked = false;
                _record.RecordEnd();
            }

        }
    }
}
