using System;
using System.Collections.Generic;
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
        private static List<Song> recentlyPlayedList;
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

        public static void UpdateRecentlyPlayedList(List<Song> _songList)
        {
            recentlyPlayedList = _songList;
        }

        public static List<Song> GetRecentlyPlayedList()
        {
            return recentlyPlayedList;
        }


        public static List<Record> GetRecordList()
        {
            return recordList;
        }
    }
}
