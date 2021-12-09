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
        private ObservableCollection<string> lovelyMusics;
        private UCRecentlyItem currentMusic;

        public static FormHome __instance;
        public static FormHome getInstance()
        {
            if (__instance == null)
                __instance = new FormHome();
            return __instance;
        }

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

            newAlbums = Albums.getInstance().GetAlbums();
            recentlyMusics = RecentlyMusics.getInstance().GetAll();
            recentlyMusics.CollectionChanged += RecentlyMusicsChange;

            lovelyMusics = LovelyMusics.getInstance().GetAll();
            lovelyMusics.CollectionChanged += LovelyMusicsChange;
        }
        public void LoadAlbums()
        {
            this.panelAlbums.Controls.Clear();

            foreach (Album album in newAlbums)
            {
                UCAlbumItem uc = new UCAlbumItem(album);
                PictureBox ptb = (PictureBox)uc.Controls.Find("pictureBoxBgr", true)[0];
                ptb.Image = album.GetCover();
                this.panelAlbums.Controls.Add(uc);
            }

            panelAlbums.AutoScroll = false;

            panelAlbums.HorizontalScroll.Maximum = 0;
            panelAlbums.HorizontalScroll.Visible = false;

            panelAlbums.AutoScroll = true;
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

        void LovelyMusicsChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    string newItem = e.NewItems[0].ToString();
                    UCLovelyItem uc = new UCLovelyItem(newItem);
                    uc.Tag = newItem;
                    this.panelLovely.Controls.Add(uc);
                    this.panelLovely.Controls.SetChildIndex(uc, 0);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    string oldItem = e.OldItems[0].ToString();
                    //Console.WriteLine(this.Parent.Location.X);
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
            LoadAlbums();
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
