using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    class Song
    {
        private string name;
        private string streamLink;
        private string beatLink;
        private string lyricLink;

        public Song(string _name = "", string _streamLink = "")
        {
            this.name = _name;
            this.streamLink = _streamLink;
        }


        public Song(string _name, string _streamLink,
            string _lyricLink, string _beatLink)
        {
            this.name = _name;
            this.streamLink = _streamLink;
            this.lyricLink = _lyricLink;
            this.beatLink = _beatLink;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetStreamLink()
        {
            return this.streamLink;
        }
        public string GetLyricLink()
        {
            return this.lyricLink;
        }

        public string GetBeatLink()
        {
            return this.beatLink;
        }
    }
}
