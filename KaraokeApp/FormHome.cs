using KaraokeApp.customControl;
using KaraokeApp.data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class FormHome : Form
    {
        private ObservableCollection<Album> newAlbums;
        private ObservableCollection<string> recentlyMusics;
        private int panelAlbumsLocation;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handlerParam = base.CreateParams;
                handlerParam.ExStyle |= 0x02000000;
                return handlerParam;
            }
        }
        public FormHome()
        {
            InitializeComponent();

            newAlbums = Albums.getInstant().GetAlbums();
            recentlyMusics = RecentlyMusics.getInstant().GetAll();
            recentlyMusics.CollectionChanged += RecentlyMusicsChange;

        }

        void RecentlyMusicsChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    UCRecentlyItem uc = new UCRecentlyItem(e.NewItems[0].ToString());
                    this.panelRecently.Controls.Add(uc);
                    this.panelRecently.Controls.SetChildIndex(uc, 0);
                    break;
                default:
                    break;
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.buttonAlbumLeft.Image = new Bitmap(Properties.Resources.icons8_left_48, new Size(20, 20));
            this.buttonAlbumRight.Image = new Bitmap(Properties.Resources.icons8_right_48, new Size(20, 20));
            foreach (Album album in newAlbums)
            {
                UCAlbumItem uc = new UCAlbumItem(album);
                this.panelAlbums.Controls.Add(uc);
            }
            foreach (string path in recentlyMusics)
            {
                try
                {
                    UCRecentlyItem uc = new UCRecentlyItem(path);
                    this.panelRecently.Controls.Add(uc);
                }
                catch
                {

                }
            }

            new TouchScroll(panelAlbums);
        }

        private void buttonAlbumLeft_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlbumRight_Click(object sender, EventArgs e)
        {
            Console.WriteLine(panelAlbumsLocation);
            if (panelAlbumsLocation + 20 < panelAlbums.HorizontalScroll.Maximum)
            {
                panelAlbumsLocation += 20;
                panelAlbums.AutoScrollPosition = new Point(panelAlbumsLocation, 0);
            }
            else
            {
                // If scroll position is above 280 set the position to 280 (MAX)
                panelAlbumsLocation = panelAlbums.HorizontalScroll.Maximum;
                panelAlbums.AutoScrollPosition = new Point(panelAlbumsLocation, 0);
            }
        }
    }
}
