using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Runtime.Serialization;

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
