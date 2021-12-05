using Shazam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.userControl
{
    public partial class UCSongItem : UserControl
    {
        public UCSongItem()
        {
            InitializeComponent();
        }
        public async Task SetPropertiesAsync(ShazamMatch match)
        {
            if (match.Cover != null)
            {
                ptbSzResult.Image = new Bitmap(new MemoryStream(await new WebClient().DownloadDataTaskAsync(new Uri(match.Cover))));
            }
            lblSong.Text = match.Title + "\n" + "By" + "\n" + match.Artist;
            btnSz.Tag = match.Link;
            btnYoutube.Tag = "https://youtube.com/results?search_query=" + WebUtility.UrlEncode(match.Artist + " - " + match.Title);
        }
        private void goTo_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;
            System.Diagnostics.Process.Start(btn.Tag.ToString());
        }
    }
}
