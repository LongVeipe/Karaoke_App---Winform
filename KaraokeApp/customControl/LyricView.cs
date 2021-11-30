using KaraokeApp.data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.customControl
{
    class LyricView : Panel 
    {
        private List<Lyric> lyricList;

        private int currentLine = 0;
        private int lineSpacing = 70;
        private bool paused = false;


        //current playing line
        private Pen currentPen;
        private Color currentColor = Color.Yellow;
        private int currentSize = 55;
        private Font font = new Font("Helvetica", 18, FontStyle.Bold);
        Brush currentBrush = new SolidBrush(Color.Yellow);
        //other line 
        private Pen otherPen;
        private Color otherColor = Color.White;
        private int otherSize = 40;
        Brush otherBrush = new SolidBrush(Color.White);
        


        public LyricView()
        {

            //this.BackColor = Color.FromArgb(25, Color.Transparent);
            //Set Lyric List
            lyricList = LyricUtil.ReadLRCFile("./ZO0AZO7E.lrc");

            //Set the current line
            currentPen = new Pen(currentColor, currentSize);
            currentPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

            //Set the other lines
            otherPen = new Pen(otherColor, otherSize);
            otherPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

            this.Paint += new PaintEventHandler(LyricView_Paint);
        }


        public void UpdateToCurrentPosition(long ms)
        {
            for(int i = currentLine; i < lyricList.Count; i++)
            {
                if (lyricList[i].timePoint <= ms)
                    currentLine = i;
                else
                    break;
            }
        }
        public void SetLRC(List<Lyric> _lyricList, Pen _currentPen,Pen _otherPen,
            int _lineSpacing)
        {
            this.lyricList = _lyricList;
            this.currentPen = _currentPen;
            this.otherPen = _otherPen;
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
            if(currentLine < lyricList.Count)
            {
                if(lyricList != null && lyricList.Count > 0)
                {
                    Lyric lyrc = null;

                    //Previous Line
                    for(int i = currentLine - 1; i >= 0;i--)
                    {
                        lyrc = lyricList[i];
                        grap.DrawString(lyrc.lyricString,font,otherBrush,0,
                            this.Height/2 + lineSpacing * (i - currentLine));

                    }

                    //Current Line
                    lyrc = lyricList[currentLine];
                    grap.DrawString(lyrc.lyricString, font, currentBrush,0,
                            this.Height / 2);



                    // Next Line
                    for(int i = currentLine + 1; i < lyricList.Count; i++)
                    {
                        lyrc = lyricList[i];
                        grap.DrawString(lyrc.lyricString, font, otherBrush,0,
                            this.Height / 2 + lineSpacing * (i - currentLine));

                    }

                    //Time between two lyric: current and next
                    int spleepTime =(int) (lyricList[currentLine + 1].timePoint -
                        lyricList[currentLine].timePoint);
                    if(!paused)
                    {
                        currentLine++;
                        DelayTime(spleepTime);
                    }                        
                }
            }

        }

       
        private async void DelayTime(int ms)
        {
            await Task.Delay(ms);
            Invalidate();
        }
    }
}
