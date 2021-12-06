using KaraokeApp.customControl;
using KaraokeApp.data;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class FormHome : Form
    {
        private ObservableCollection<Album> newAlbums;
        private ObservableCollection<string> recentlyMusics;
        private UCRecentlyItem currentMusic;

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
            panelAlbums.AutoScroll = false;

            panelAlbums.HorizontalScroll.Maximum = 0;
            panelAlbums.HorizontalScroll.Visible = false;

            panelAlbums.AutoScroll = true;


            newAlbums = Albums.getInstant().GetAlbums();
            recentlyMusics = RecentlyMusics.getInstant().GetAll();
            recentlyMusics.CollectionChanged += RecentlyMusicsChange;
        }

        void RecentlyMusicsChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    string path = e.NewItems[0].ToString();
                    UCRecentlyItem uc = new UCRecentlyItem(path);
                    uc.Tag = path;
                    this.panelRecently.Controls.Add(uc);
                    this.panelRecently.Controls.SetChildIndex(uc, 0);
                    break;
                default:
                    break;
            }
        }
        public void PlayRecently(UCRecentlyItem uc)
        {
            if(currentMusic != null)
            {
                currentMusic.PauseMusic();
            }
            currentMusic = uc;
            ((FormMain)(this.Parent.Parent.Parent)).PlayMusic(uc.Tag.ToString());
        
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
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
                    uc.Tag = path;
                    this.panelRecently.Controls.Add(uc);
                }
                catch
                {

                }
            }

            new TouchScroll(panelAlbums);
        }

    }
}
