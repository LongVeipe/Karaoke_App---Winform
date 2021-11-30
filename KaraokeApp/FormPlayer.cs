using KaraokeApp.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
            
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
    }
}
