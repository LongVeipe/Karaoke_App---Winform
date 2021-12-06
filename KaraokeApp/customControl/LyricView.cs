using KaraokeApp.data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.customControl
{
    class LyricView : Panel
    {

        private const string LYRIC_PATH = "../../Resources/lyric/";
        private const string KARA_PATH = "../../Resources/lyric/";
        private const string STREAM_PATH = "../../Resources/streaming/";



        // Lyric and Kara List for the current song
        private List<Lyric> lyricList;
        private List<KaraSetence> sentences;


        //private int currentWord = 0;
        //private int currentCharacter = 0;

        // Timer to use for frame
        private Timer timer = new Timer();


        // Setting for view
        private int nextSenteceTime = -1;
        private bool paused = false;
        private bool karaokeMod = false;
        private int currentLine = 0;
        private int lineSpacing = 70;






        //current playing line
        private static Color currentColor = Color.Yellow;
        private int currentSize = 18;
        private static FontFamily f = new FontFamily("Helvetica");
        private static Font font = new Font(f, 18, FontStyle.Bold);
        Brush currentBrush = new SolidBrush(currentColor);



        //other line 
        private static Color otherColor = Color.White;
        private int otherSize = 40;
        Brush otherBrush = new SolidBrush(otherColor);



        public LyricView()
        {

            if(DataPool.GetCurrentSong() != null)
            {
                string currentSongName = DataPool.GetCurrentSong().GetName();
                //Set Lyric List
                lyricList = LyricUtil.ReadLRCFile(LYRIC_PATH + currentSongName
                    + ".lrc");
                sentences = LyricUtil.ReadKaraFile(KARA_PATH + currentSongName
                    + ".txt");
            }
          
            // 1 frame every 100ms
            this.DoubleBuffered = true;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();


            // Render method for panel
            this.Paint += new PaintEventHandler(LyricView_Paint);


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void UpdateToCurrentPosition(double ms)
        {

            if(ms == 0)
            {
                currentLine = 0;

            }
            else
            {
                for (int i = 0; i < lyricList.Count; i++)
                {
                    if (lyricList[i].timePoint <= ms)
                        currentLine = i;
                    else
                        break;
                }

            }
           

        }
        public void UpdateLyricList()
        {
            if (DataPool.GetCurrentSong() != null)
            {
                currentLine = 0;
                string currentSongName = DataPool.GetCurrentSong().GetName();
                //Set Lyric List
                lyricList = LyricUtil.ReadLRCFile(LYRIC_PATH + currentSongName
                    + ".lrc");
                sentences = LyricUtil.ReadKaraFile(KARA_PATH + currentSongName
                    + ".txt");
            }
        }

        public void SetLRC(List<Lyric> _lyricList, int _lineSpacing)
        {
            this.lyricList = _lyricList;
            this.lineSpacing = _lineSpacing;
        }


        public void PauseLyric()
        {
            paused = true;
        }


        public void ContinueLyric()
        {
            paused = false;
            Invalidate();
        }
        private void LyricView_Paint(object sender, PaintEventArgs e)
        {
            Panel pnlLyricView = sender as Panel;
            Graphics grap = e.Graphics;
            //this.BackColor = Color.FromArgb(100, 0, 0, 0);
            Render(grap);


        }

        private void Render(Graphics grap)
        {
            if (DataPool.GetCurrentSong() != null)
            {
                if (!karaokeMod)
                    LyricMode(grap);
                else
                    KaraokeMode(grap);

            }
        }


        public void SwitchToKaraokeMode()
        {
            karaokeMod = true;
            
        }

        public void SwitchToLyricMode()
        {
            karaokeMod = false;
           
        }


        private void KaraokeMode(Graphics grap)
        {
            if (currentLine < sentences.Count)
            {
                if (sentences != null && sentences.Count > 0)
                {
                    double currentTime = DataPool.Player.Ctlcontrols.currentPosition * 1000.0;
                    if (currentLine == 0 &&
                       lyricList[currentLine].timePoint - currentTime > 2000)
                    {
                        string currentSongName = DataPool.GetCurrentSong().GetName();
                        // Get the artist and title 
                        // Switch to current Song instead of using hard code
                        string artist = SongUtil.GetArtist(STREAM_PATH +  currentSongName + ".mp3");
                        string title = SongUtil.GetTile(STREAM_PATH + currentSongName +".mp3");


                        SizeF hStringSize = grap.MeasureString(artist, font);
                        SizeF lStringSize = grap.MeasureString(title, font);


                        grap.DrawString(artist, font, otherBrush,
                             (this.Width - hStringSize.Width) / 2,
                             this.Height / 2 - lineSpacing);


                        grap.DrawString(title, font, otherBrush,
                          (this.Width - lStringSize.Width) / 2,
                          this.Height / 2);

                    }
                    else
                    {
                        DrawCurrentLineKara(grap, currentTime, currentLine);
                        if (currentLine + 1 < sentences.Count)
                        {
                            Lyric nextSen = lyricList[currentLine + 1];
                            SizeF hStringSize = grap.MeasureString(nextSen.lyricString, font);
                            if (currentLine % 2 == 0)
                            {

                                grap.DrawString(nextSen.lyricString, font, otherBrush,
                                    (this.Width - hStringSize.Width) / 2,
                                     this.Height / 2);

                            }
                            else
                            {

                                grap.DrawString(nextSen.lyricString, font, otherBrush,
                                     (this.Width - hStringSize.Width) / 2,
                                      this.Height / 2 - lineSpacing);
                            }

                            nextSenteceTime = (int)lyricList[currentLine + 1].timePoint;

                            if (!paused)
                            {
                                if (currentTime >= nextSenteceTime)
                                    currentLine++;
                            }

                        }
                       

                    }

                }

            }
        }

        private void LyricMode(Graphics grap)
        {
            if (currentLine < lyricList.Count)
            {
                if (lyricList != null && lyricList.Count > 0)
                {
                    double currentTime = DataPool.Player.Ctlcontrols.currentPosition * 1000;


                    if (currentLine == 0 &&
                        lyricList[currentLine].timePoint - currentTime > 2000)
                    {

                        string currentSongName = DataPool.GetCurrentSong().GetName();
                        // Get the artist and title 
                        // Switch to current Song instead of using hard code
                        string artist = SongUtil.GetArtist(STREAM_PATH + currentSongName + ".mp3");
                        string title = SongUtil.GetTile(STREAM_PATH + currentSongName + ".mp3");


                        SizeF hStringSize = grap.MeasureString(artist, font);
                        SizeF lStringSize = grap.MeasureString(title, font);


                        grap.DrawString(artist, font, otherBrush,
                             (this.Width - hStringSize.Width) / 2,
                             this.Height / 2 - lineSpacing);


                        grap.DrawString(title, font, otherBrush,
                          (this.Width - lStringSize.Width) / 2,
                          this.Height / 2);

                    }
                    else
                    {
                        Lyric lyrc = null;

                        //Previous Line
                        for (int i = currentLine - 1; i >= 0; i--)
                        {
                            lyrc = lyricList[i];
                            SizeF hStringSize = grap.MeasureString(lyrc.lyricString, font);
                            grap.DrawString(lyrc.lyricString, font, otherBrush,
                                (this.Width - hStringSize.Width) / 2,
                                this.Height / 2 + lineSpacing * (i - currentLine));

                        }

                        //Current Line
                        lyrc = lyricList[currentLine];
                        SizeF cStringSize = grap.MeasureString(lyrc.lyricString, font);
                        grap.DrawString(lyrc.lyricString, font, currentBrush,
                             (this.Width - cStringSize.Width) / 2,
                                this.Height / 2);


                        // Next Line
                        for (int i = currentLine + 1; i < lyricList.Count; i++)
                        {
                            lyrc = lyricList[i];
                            SizeF nStringSize = grap.MeasureString(lyrc.lyricString, font);
                            grap.DrawString(lyrc.lyricString, font, otherBrush,
                                (this.Width - nStringSize.Width) / 2,
                                this.Height / 2 + lineSpacing * (i - currentLine));

                        }

                        // Calculate to move on to the next line
                        if (currentLine + 1 < lyricList.Count)
                        {
                            nextSenteceTime = (int)lyricList[currentLine + 1].timePoint;
                            if (!paused)
                            {
                                if (currentTime >= nextSenteceTime)
                                    currentLine++;
                            }
                        }

                    }

                }
            }
        }

        private void DrawCurrentLineKara(Graphics grap, double currentTime, int line)
        {
            string hightLightString = "";
            string normalString = "";
            for (int currentWord = 0; currentWord < sentences[currentLine].words.Count; currentWord++)
            {

                Word w = sentences[currentLine].words[currentWord];
                if (currentTime > w.startTime - 200 && currentTime < w.endTime - 200)
                {

                    hightLightString += w.data + " ";
                }
                else if (currentTime > w.endTime - 200)
                {
                    hightLightString += w.data + " ";
                }
                else if (currentTime < w.startTime - 200)
                {
                    normalString += w.data + " ";
                }
            }
            SizeF hStringSize = grap.MeasureString(hightLightString, font);
            SizeF senWidth = grap.MeasureString(hightLightString + normalString, font);

            // If the current line is odd, it's will display current line below
            // other side, it's will display above
            if (currentLine % 2 == 0)
            {

                grap.DrawString(hightLightString, font, currentBrush,
                    (this.Width - senWidth.Width) / 2,
                     this.Height / 2 - lineSpacing);

                grap.DrawString(normalString, font, otherBrush,
                    (this.Width - senWidth.Width) / 2 + hStringSize.Width - 3,
                  this.Height / 2 - lineSpacing);


            }
            else
            {
                grap.DrawString(hightLightString, font, currentBrush,
                    (this.Width - senWidth.Width) / 2,
                   this.Height / 2);


                grap.DrawString(normalString, font, otherBrush,
                   (this.Width - senWidth.Width) / 2 + hStringSize.Width - 3,
                    this.Height / 2);
            }
        }
    }
}
