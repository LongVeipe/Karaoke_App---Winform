﻿using System;
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

namespace KaraokeApp
{
    
    public partial class UCLovelyItem : UserControl
    {
        string musicPath;
        Dictionary<int, Bitmap> randArtworks;
        public UCLovelyItem(string musicPath)
        {
            InitializeComponent();
            this.musicPath = musicPath;


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
        private  void UCRecentlyItem_Load(object sender, EventArgs e)
        {
            string artist = "Unknown", title = "Unknown";
            Bitmap artwork;

            TagLib.File file = TagLib.File.Create(musicPath);
            string[] artists = file.Tag.Artists;
            artist = artists.Length > 0 ? artists.FirstOrDefault() : "Unknown";
            title = file.Tag.Title != null ? file.Tag.Title : "Unknown";
            artwork = GetMp3Artwork(file);

            if (artwork != null)
                this.pictureBoxArtwork.Image = artwork;
            else
            {
                int randArtworkey = (new Random()).Next(1, 6);
                if (randArtworks.TryGetValue(randArtworkey, out artwork))
                    this.pictureBoxArtwork.Image = artwork;
            }
            labelArtist.Text = artist;
            labelTitle.Text = title;
        }

        public void PauseMusic()
        {
            buttonPlay.Visible = true;
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
        }

        private void buttonLovely_Click(object sender, EventArgs e)
        {
            LovelyMusics.getInstance().Remove(musicPath);
            this.Dispose();
        }
    }
}