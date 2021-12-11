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

namespace KaraokeApp.userControl
{
    public partial class UCSong : UserControl
    {
        private Song songItem;
        public UCSong()
        {
            InitializeComponent();
        }
        public UCSong(Song _song)
        {
            InitializeComponent();
            this.songItem = _song;
            this.lblSongName.Text = songItem.GetTitle();

            string beatUrl = songItem.GetBeatLink();
            if(beatUrl == null || beatUrl == "")
            {
                btnPlayKaraoke.Visible = false;
            }
        }

        private void btnPlayStream_Click(object sender, EventArgs e)
        {
            //buttonPlay.Visible = false;
            string absolutePath = Path.GetFullPath(songItem.GetStreamLink());
            ((FormList)(this.Parent.Parent.Parent))
                .PlaySong(this, absolutePath);
            DataPool.UpdateCurrentSong(songItem);
        }

        private void btnPlayKaraoke_Click(object sender, EventArgs e)
        {
            DataPool.UpdateCurrentSong(songItem);

            ((FormList)(this.Parent.Parent.Parent))
               .PlayKaraoke(this);
        }
    }
}
