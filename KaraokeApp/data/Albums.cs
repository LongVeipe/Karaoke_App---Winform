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

        private static Albums __instance;

        public static Albums getInstance()
        {
            if (__instance == null)
                __instance = new Albums();
            return __instance;
        }

        private ObservableCollection<Album> albums;

        public Albums()
        {
            this.albums = new ObservableCollection<Album>();
            //InitData();
        }

        public void AddData(List<Album> albs)
        {
            foreach(Album a in albs)
                this.albums.Add(a);
        }

        public ObservableCollection<Album> GetAlbums()
        {
            return this.albums;
        }
    }
}
