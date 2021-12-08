using KaraokeApp.data;
using KaraokeApp.userControl;
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
    public partial class FormList : Form
    {
        private UCSong currentActivedItem;
        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            foreach(Song songIndex in DataPool.GetSongList())
            {
                flowPNLListSong.Controls.Add(new UCSong(songIndex));
            }
        }


        public void PlaySong(UCSong currentItem, string filePath)
        {
            if (currentActivedItem != null)
            {
                //currentMusic.PauseMusic();
            }
            currentActivedItem = currentItem;
            ((FormMain)(this.Parent.Parent.Parent)).PlayMusic(filePath);
        }


        public void PlayKaraoke(UCSong currentItem)
        {
            if (currentActivedItem != null)
            {
                //currentMusic.PauseMusic();
            }
            currentActivedItem = currentItem;
            ((FormMain)(this.Parent.Parent.Parent)).PlayingKaraoke();
        }
    }
}
