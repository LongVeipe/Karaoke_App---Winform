using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    public class Record    
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



        public Record(string _name, string _streamLink)
        {
            this.name = _name;
            this.streamLink = _streamLink;

        }
        public string GetName()
        {
            return this.name;
        }

        public string GetStreamLink()
        {
            return this.streamLink;
        }
    }
}
