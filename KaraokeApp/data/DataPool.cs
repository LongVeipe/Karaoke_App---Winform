using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;

namespace KaraokeApp.data
{
    class DataPool
    {
        private static List<Song> songList;
        private static Song currentSong;
        private static ObservableCollection<Song> recentlyPlayedList;
        private static ObservableCollection<Song> favouriteList;
        private static List<Song> queue;
        private static List<Record> recordList;
        public static AxWindowsMediaPlayer Player;


        public static void UpdateCurrentSong(Song _song)
        {
            currentSong = _song;
        }

        public static Song GetCurrentSong()
        {
            return currentSong;
        }
        
        public static void UpdateSongList(List<Song> _songList)
        {
            songList = _songList;
        }

        public static void UpdateRecordList(List<Record> _recordList)
        {
            recordList = _recordList;
        }
        public static int GetNumberRecord()
        {
            return recordList.Count;
        }
        public static void  InsertRecord(Record _record)
        {
            recordList.Add(_record);

        }
        public static List<Song> GetSongList()
        {
            return songList;
        }

        public static void UpdateRecentlyPlayedList(ObservableCollection<Song> _songList)
        {
            recentlyPlayedList = _songList;
        }

        public static ObservableCollection<Song>GetRecentlyPlayedList()
        {
            if (recentlyPlayedList == null)
                recentlyPlayedList = new ObservableCollection<Song>();
            return recentlyPlayedList;
        }


        public static List<Record> GetRecordList()
        {
            return recordList;
        }



        public static ObservableCollection<Song> GetFavouriteList()
        {
            if (favouriteList == null)
                favouriteList = new ObservableCollection<Song>();
            return favouriteList;
        }

        public static List<Song> GetQueue()
        {
            if (queue == null)
                queue = new List<Song>();
            return queue;
        }


        public static void UpdateQueue(List<Song> _songs)
        {
            queue = _songs;
        }

        public static void InsertToQueue(Song _song)
        {
            if (queue == null)
                queue = new List<Song>();
            queue.Add(_song);

        }

        public static void InsertToSongList(Song _song)
        {
            songList.Add(_song);
        }
        public static void InsertToFavouriteList(Song _song)
        {
            if(favouriteList == null)
            {
                favouriteList = new ObservableCollection<Song>();
            }
            favouriteList.Add(_song);
        }

        public static void RemoveFromFavouriteList(Song _song)
        {
            if(_song != null)
            {
                favouriteList.Remove(_song);
            }
        }
        public static bool InsertToRecentlyPlayedList(Song _song)
        {
            if (recentlyPlayedList == null)
                recentlyPlayedList = new ObservableCollection<Song>();
            bool isAlreadyAdded = false;
            foreach(Song songIndex in recentlyPlayedList)
            {
                if (songIndex == _song)
                    isAlreadyAdded = true;
            }
            if(!isAlreadyAdded)
            {
                recentlyPlayedList.Add(_song);
                return isAlreadyAdded;
            }
            return isAlreadyAdded;
        }

        public static Song SearchInSongList(String streamFile)
        {
            Song mySong = null;
            foreach (Song songIndex in songList)
            {
                string absolutePath = Path.GetFullPath(songIndex.streamLink);
                if(absolutePath == streamFile)
                {
                    mySong = songIndex;
                    return mySong;
                }
            }
            return mySong;
        }

        

        public static void ClearQueue()
        {
            queue = null;
        }

        public static void FillFavouriteList()
        {
            favouriteList = new ObservableCollection<Song>();
            foreach(Song song in songList)
            {
                if(song.isFavourite)
                {
                    favouriteList.Add(song);
                }
            }
        }
    }
}
