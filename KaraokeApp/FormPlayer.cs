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
        private const string RECORD_PATH = "../../Resources/record/";

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
            SetMode();


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

                //Animation
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
        public void SetKaraokeMode()
        {
            if (DataPool.GetCurrentSong() != null)
            {
                karaokeMode = true;
                backgroundPanel.BackgroundImage = backgroundList[0];
                btnKaraoke.Enabled = false;
                btnLyric.Enabled = true;
                pnlRecord.Visible = true;
            }
        }

        public void SetLyricMode()
        {
            if (DataPool.GetCurrentSong() != null)
            {
                karaokeMode = false;
                btnKaraoke.Enabled = true;
                btnLyric.Enabled = false;
                timer.Stop();
                lyricViewPanel.SwitchToLyricMode();
                pnlRecord.Visible = false;
            }
        }
        
        public void SetMode()
        {
            string currentURL = DataPool.Player.URL;
            if(currentURL.Contains(".m4a"))
            {
                SetKaraokeMode();
            }
            else if(currentURL.Contains(".mp3"))
            {
                SetLyricMode();
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
                    ((FormMain)(this.Parent.Parent.Parent)).PauseMusic();
                }

            }
            else
            {
                btnRecord.Checked = true;
                if (_record == null)
                {
                    /// 0 == The first input device driver in your desktop
                    string title = DataPool.GetCurrentSong().GetTitle();
                    int recordID = DataPool.GetNumberRecord();
                    _record = new Recorder(RECORD_PATH, 
                        title + recordID.ToString() + ".wav", 0);
                    _record.StartRecording();
                    double currentTime = DataPool.Player.Ctlcontrols.currentPosition;
                    _record.SetStartPosition(TimeSpan.FromSeconds(currentTime));
                }
                else if (_record.isPaused == true)
                {
                    _record.ResumeRecording();
                    ((FormMain)(this.Parent.Parent.Parent)).PlayMusic();
                }   
            }
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            if(btnRecord.Checked && _record != null)
            {
                btnRecord.Checked = false;

                try
                {
                    // Done Record and begin to mix file1
                    _record.RecordEnd();
                    double currentTime = DataPool.Player.
                        Ctlcontrols.currentPosition;
                    _record.SetEndPosition(TimeSpan.FromSeconds(currentTime));
                    _record.MixingAudio(DataPool.GetCurrentSong().GetBeatLink());
                }
                catch
                {

                }
                finally
                {
                    _record.DeleteMicFile();
                    _record = null;
                    MessageBox.Show("Thu âm thành công!");
                }
            }

        }
    }
}
