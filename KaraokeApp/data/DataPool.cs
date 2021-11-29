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
        private static List<Album> albumList;
        private static Song currentSong;


        public static void UpdateCurrentSong(Song _currentSong)
        {
            currentSong = _currentSong;
        }


        public static Song GetCurrentSong()
        {
            return currentSong;
        }


        public static void UpdateSongList(List<Song> _songList)
        {
            songList = _songList;
        }

        public static List<Song> GetCurrentSongList()
        {
            return songList;
        }
    }
}
