using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaraokeApp.data;

namespace KaraokeApp
{
    public partial class UCAlbumItem : UserControl
    {
        Album album;
        public UCAlbumItem(Album album)
        {
            InitializeComponent();
            this.album = album;
        }

        private void AlbumItem_Load(object sender, EventArgs e)
        {
            var posArtist = this.PointToScreen(labelArtist.Location);
            posArtist = pictureBoxBgr.PointToClient(posArtist);
            labelArtist.Parent = pictureBoxBgr;
            labelArtist.Location = posArtist;
            labelArtist.BackColor = Color.Transparent;

            var posTitle = this.PointToScreen(labelTitle.Location);
            posTitle = pictureBoxBgr.PointToClient(posTitle);
            labelTitle.Parent = pictureBoxBgr;
            labelTitle.Location = posTitle;
            labelTitle.BackColor = Color.Transparent;

            this.labelArtist.Text = album.GetArtist();
            this.labelTitle.Text = album.GetTitle();
        }
    }
}
