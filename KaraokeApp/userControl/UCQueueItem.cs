using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KaraokeApp.data;

namespace KaraokeApp.userControl
{
    public partial class UCQueueItem : UserControl
    {
        private Song songItem;
        private bool isChecked;
        Dictionary<int, Bitmap> randArtworks;
        public UCQueueItem(Song _song)
        {
            InitializeComponent();

            this.songItem = _song;
            randArtworks = new Dictionary<int, Bitmap>();
            randArtworks.Add(1, Properties.Resources.fullClrBgr1);
            randArtworks.Add(2, Properties.Resources.fullClrBgr2);
            randArtworks.Add(3, Properties.Resources.fullClrBgr3);
            randArtworks.Add(4, Properties.Resources.fullClrBgr4);
            randArtworks.Add(5, Properties.Resources.fullClrBgr5);
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

        public void SetChecked(bool c)
        {
            this.isChecked = c;
            if(c)
            {
                this.BackColor = Color.FromArgb(29, 30, 53);
            }
            else
            {
                this.BackColor = Color.Transparent;
            }
        }
        public void UnCheckedLovely()
        {
            this.buttonLovely.Checked = false;
        }
        private void buttonLovely_Click(object sender, EventArgs e)
        {
            if (buttonLovely.Checked)
            {
                songItem.SetUnfavouriteSong();
                DataPool.RemoveFromFavouriteList(songItem);
            }
            else
            {
                songItem.SetFavouriteSong();
                DataPool.InsertToFavouriteList(songItem);
            }

            buttonLovely.Checked = !buttonLovely.Checked;
        }

        private void UCQueueItem_Load(object sender, EventArgs e)
        {
            string artist = "Unknown", title = "Unknown";
            Bitmap artwork;

            artist = songItem.GetArtist();
            title = songItem.GetTitle();
            artwork = songItem.GetArt();

            if (artwork != null)
                this.pictureBoxArtwork.Image = artwork;
            else
            {
                int randArtworkey = (new Random()).Next(1, 6);
                if (randArtworks.TryGetValue(randArtworkey, out artwork))
                    this.pictureBoxArtwork.Image = artwork;
            }

            if (songItem.isFavourite)
                buttonLovely.Checked = true;
            labelArtist.Text = artist;
            labelTitle.Text = title;
        }

        private void buttonLovely_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(buttonLovely.Checked);
        }

        public string GetStreamPath()
        {
            return songItem.GetStreamLink();
        }
    }
}
