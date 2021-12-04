using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Runtime.Serialization;
using System.Drawing;
using System.IO;

namespace KaraokeApp.data
{
    class Song
    {

        [BsonId]
        [DataMember]
        public MongoDB.Bson.ObjectId _id { get; set; }

        [DataMember]
        [BsonElement("name")]
        public string name { get; set; }

        [DataMember]
        [BsonElement("streamLink")]
        public string streamLink { get; set; }

        [DataMember]
        [BsonElement("beatLink")]
        public string beatLink { get; set; }

        [DataMember]
        [BsonElement("lyricLink")]
        public string lyricLink { get; set; }

        [BsonIgnore]
        public string[] artists { get; set; }
        [BsonIgnore]
        public string title { get; set; }
        [BsonIgnore]
        public Bitmap art { get; set; } 


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

        public string GetArtist()
        {
           if(artists == null)
           {
                this.artists[0] = SongUtil.GetArtist(this.lyricLink);
           }
            return artists[0];
        }


        public string GetTitle()
        {
            if(title == null)
            {
                this.title = SongUtil.GetTile(this.lyricLink);
            }
            return this.title;
        }


        public Bitmap GetArt()
        {
            if(art == null)
            {
                this.art = SongUtil.GetArt(this.lyricLink);
            }
            return art;
        }
    }


    class SongUtil
    {
        public static string GetArtist(string filePath)
        {
            string artist = "Unknown";
            TagLib.File file = TagLib.File.Create(filePath);
            string[] artists = file.Tag.Artists;
            artist = artists.Length > 0 ? artists.FirstOrDefault() : "Unknown";
            return artist;
        }


        public static string GetTile(string filePath)
        {
            string title = "Unknown";
            TagLib.File file = TagLib.File.Create(filePath);
            title = file.Tag.Title != null ? file.Tag.Title : "Unknown";
            return title;
        }



        public static Bitmap GetArt(string filePath)
        {
            Bitmap art = null;
            var mStream = new MemoryStream();
            TagLib.File file = TagLib.File.Create(filePath);
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            else
            {
                // set "no cover" image
                return null;
            }
        }
    }
}
