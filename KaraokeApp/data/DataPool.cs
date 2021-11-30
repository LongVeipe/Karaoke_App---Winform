using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    class DataPool
    {
        private static List<Song> songList;
        private static Song currentSong;
        private static List<Song> recentlyPlayedList;
        private static List<Album> albumList;


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
    }
}
