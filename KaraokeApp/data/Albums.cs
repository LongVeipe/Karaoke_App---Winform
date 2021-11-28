using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    public class Album
    {
        private string artist;
        private string title;

        public Album(string title = "", string artist = "")
        {
            this.title = title;
            this.artist = artist;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetArtist()
        {
            return this.artist;
        }
    }
    class Albums
    {

        private static Albums __instant;

        public static Albums getInstant()
        {
            if (__instant == null)
                __instant = new Albums();
            return __instant;
        }

        private ObservableCollection<Album> albums;

        public Albums()
        {
            this.albums = new ObservableCollection<Album>();
            InitData();
        }

        private void InitData()
        {
            this.albums.Add(new Album("Album 1", "Artist 1"));
            this.albums.Add(new Album("Album 2", "Artist 2"));
            this.albums.Add(new Album("Album 3", "Artist 3"));
        }
        public ObservableCollection<Album> GetAlbums()
        {
            return this.albums;
        }
    }
}
