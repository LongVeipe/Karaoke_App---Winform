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
        private const string streamingPath = "../../Resources/streaming/";
        private const string lyricPath = "../../Resources/lyric/";
        private const string beatPath = "../../Resources/beat/";
        private const string recordPath = "../../Resources/record/";
        private static MongoClient client = null;
        private static IMongoCollection<Song> songCollection = null;
        private static IMongoCollection<Record> recordCollection= null;

        public static void CreateConnection()
        {
            if(client == null)
            {
                try
                {
                    client = new MongoClient("mongodb://localhost:27017");
                    IMongoDatabase mDatabase = client.GetDatabase("KaraokeApp");
                    songCollection = mDatabase.GetCollection<Song>("song");
                    recordCollection = mDatabase.GetCollection<Record>("record");

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

        public static void SaveRecord(Record _record)
        {
            recordCollection.InsertOne(_record);

        }


        public static List<Song> GetAllSongInDatabase()
        {
            return songCollection.Find(new BsonDocument()).ToList();
        }

        public static List<Record> GetAllRecordInDatabase()
        {
            return recordCollection.Find(new BsonDocument()).ToList();
        }
        public static void Seeder()
        {
            // Song (Name, StreamingPath, LyricPath, BeatPath)
            songCollection.InsertOne(new Song("ZU6EWUEA", streamingPath + "ZU6EWUEA.mp3",
                lyricPath + "ZU6EWUEA.lrc", ""));
            songCollection.InsertOne(new Song("ZUAO7IZU", streamingPath + "ZUAO7IZU.mp3",
               lyricPath + "ZUAO7IZU.lrc", ""));
            songCollection.InsertOne(new Song("ZUB8D7FI", streamingPath + "ZUB8D7FI.mp3",
               lyricPath + "ZUB8D7FI.lrc", ""));
            songCollection.InsertOne(new Song("ZUB8D7FU", streamingPath + "ZUB8D7FU.mp3",
               lyricPath + "ZUB8D7FU.lrc", ""));
            songCollection.InsertOne(new Song("ZUB8D80E", streamingPath + "ZUB8D80E.mp3",
               lyricPath + "ZU6EWUEA.lrc", ""));
            songCollection.InsertOne(new Song("ZUB8D80I", streamingPath + "ZUB8D80I.mp3",
               lyricPath + "ZUB8D80I.lrc", ""));
            songCollection.InsertOne(new Song("ZW6B769F", streamingPath + "ZW6B769F.mp3",
              lyricPath + "ZW6B769F.lrc", beatPath + "ZW6B769F.m4a"));
            songCollection.InsertOne(new Song("ZW6BF00F", streamingPath + "ZW6BF00F.mp3",
              lyricPath + "ZW6BF00F.lrc", beatPath + "ZW6BF00F.m4a"));
            songCollection.InsertOne(new Song("ZW6UO6DF", streamingPath + "ZW6UO6DF.mp3",
              lyricPath + "ZW6UO6DF.lrc", beatPath + "ZW6UO6DF.m4a"));
            songCollection.InsertOne(new Song("ZW6WU0UB", streamingPath + "ZW6WU0UB.mp3",
              lyricPath + "ZW6WU0UB.lrc", beatPath + "ZW6WU0UB.m4a"));
            songCollection.InsertOne(new Song("ZW7O777O", streamingPath + "ZW7O777O.mp3",
              lyricPath + "ZW7O777O.lrc", ""));
        }


        public static void FillDataPool()
        {
            DataPool.UpdateSongList(GetAllSongInDatabase());
            DataPool.UpdateRecordList(GetAllRecordInDatabase());
        }

    }
}

