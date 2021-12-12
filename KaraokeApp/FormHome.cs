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
        private ObservableCollection<Song> recentlyMusics;
        private ObservableCollection<Song> lovelyMusics;
        private UCRecentlyItem currentMusic;

        private Form parentForm = null;
       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handlerParam = base.CreateParams;
                handlerParam.ExStyle |= 0x02000000;
                return handlerParam;
            }
        }
        public FormHome(Form _parentForm)
        {
            InitializeComponent();

            recentlyMusics = DataPool.GetRecentlyPlayedList();
            lovelyMusics = DataPool.GetFavouriteList();

            this.parentForm = _parentForm;

            recentlyMusics.CollectionChanged += RecentlyMusicsChange;

            lovelyMusics.CollectionChanged += LovelyMusicsChange;

            panelLovely.AutoScroll = false;

            panelLovely.VerticalScroll.Maximum = 0;
            panelLovely.VerticalScroll.Visible = false;

            panelLovely.AutoScroll = true;


            panelRecently.AutoScroll = false;

            panelRecently.VerticalScroll.Maximum = 0;
            panelRecently.VerticalScroll.Visible = false;

            panelRecently.AutoScroll = true;

        }
        public void LoadAlbums()
        {
            this.panelAlbums.Controls.Clear();

       
            panelAlbums.AutoScroll = false;

            panelAlbums.HorizontalScroll.Maximum = 0;
            panelAlbums.HorizontalScroll.Visible = false;

            panelAlbums.AutoScroll = true;
        }


        public void LoadFavouriteList()
        {
            foreach (Song songIndex in lovelyMusics)
            {
                    UCLovelyItem uc = new UCLovelyItem(songIndex);
                    uc.Tag = songIndex.GetStreamLink();
                    this.panelLovely.Controls.Add(uc);
            }
        }
        void RecentlyMusicsChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                     Song path = ((Song)e.NewItems[0]);
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
                    Song newItem = (Song)e.NewItems[0];
                    UCLovelyItem uc = new UCLovelyItem(newItem);
                    uc.Tag = newItem.GetStreamLink();
                    this.panelLovely.Controls.Add(uc);
                    this.panelLovely.Controls.SetChildIndex(uc, 0);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Song oldItem = (Song)e.OldItems[0];
                    ((FormMain)parentForm).RemoveLovelyInQueue(oldItem.GetStreamLink());
                    RemoveUCLovelyItem(oldItem.GetStreamLink());
                    break;
                default:
                    break;
            }
        }
       
        void RemoveUCLovelyItem(string path)
        {
            foreach (Control item in panelLovely.Controls)
            {
                if (item.Tag.ToString() == path)
                {
                    UCLovelyItem uc = (UCLovelyItem)item;
                    uc.Dispose();
                }
            }
        }
        public void PlayRecently(UCRecentlyItem uc)
        {
            if(currentMusic != null)
            {
                currentMusic.PauseMusic();
            }
            currentMusic = uc;
            ((FormMain)(this.Parent.Parent.Parent)).PlaySong(uc.GetSongItem());
        
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            LoadAlbums();
            LoadFavouriteList();
            foreach (Song songIndex in recentlyMusics)
            {
                try
                {
                    UCRecentlyItem uc = new UCRecentlyItem(songIndex);
                    uc.Tag = songIndex.GetStreamLink();
                    this.panelRecently.Controls.Add(uc);
                }
                catch
                {

                }
            }

            //new TouchScroll(panelAlbums);
        }

        private void panelLovely_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
