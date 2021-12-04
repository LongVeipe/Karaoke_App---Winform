using KaraokeApp.data;
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
        // Timer to use for frame
        private const int MAXIMUMSCALE = 50;
        private Timer timer = new Timer();
        private List<Bitmap> backgroundList;
        private int currentIndex = 0;
        private bool karaokeMode = false;
        //private int scale = 0;
        public FormPlayer()
        {
            InitializeComponent();
            DoubleBuffered = true;
            AddBackgroundImage();
            // 1 frame every 100ms
            this.DoubleBuffered = true;
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();

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
            string[] filePaths = Directory.GetFiles(@"../../Resources/Background_Karaoke"
                                    , "*.jpg");
            foreach (string index in filePaths)
            {
                backgroundList.Add(new Bitmap(index));
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(karaokeMode == true)
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

        public void UpdateLyric(long ms)
        {
            if(DataPool.GetCurrentSong() != null)
                lyricViewPanel.UpdateToCurrentPosition(ms);
        }

        public void PauseLyric()
        {
            lyricViewPanel.PauseLyric();
        }

        public void ContinueLyric(long ms)
        {
            lyricViewPanel.UpdateToCurrentPosition(ms);
            lyricViewPanel.ContinueLyric();
        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {
            karaokeMode = true;
            backgroundPanel.BackgroundImage = backgroundList[0];
            timer.Start();
            lyricViewPanel.SwitchToKaraokeMode();
        }

        private void btnLyric_Click(object sender, EventArgs e)
        {
            karaokeMode = false;
            timer.Stop();
            lyricViewPanel.SwitchToLyricMode();
        }
    }
}
