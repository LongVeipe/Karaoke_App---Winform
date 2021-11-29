using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace KaraokeApp.data
{
    class DatabaseHelper
    {
        private static MongoClient client = null;
        private static IMongoCollection<Song> songCollection = null;

        public static void CreateConnection()
        {
            if(client == null)
            {
                try
                {
                    client = new MongoClient("mongodb://localhost:27017");
                    IMongoDatabase mDatabase = client.GetDatabase("KaraokeApp");
                    songCollection = mDatabase.GetCollection<Song>("song");

                    System.Console.WriteLine("Connect to MongoDB successfully at port 27017");
                }
                catch
                {
                    System.Console.WriteLine("Meet error when connecting to DB");

                }
            }
        }

        public static void SaveSong(Song song)
        {
            songCollection.InsertOne(song);
        }

        public List<Song> GetAllSong()
        {
            return songCollection.Find(new BsonDocument()).ToList();
        }

        

    }
}
