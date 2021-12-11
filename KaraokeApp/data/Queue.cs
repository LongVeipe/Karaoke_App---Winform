using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    class QueueItem
    {
        private string musicPath;
        private int id;

        public QueueItem(int _id, string _musicPath)
        {
            id = _id;
            musicPath = _musicPath;
        }

        public string GetMusicPath()
        {
            return this.musicPath;
        }

        public int getId()
        {
            return this.id;
        }
    }
    class Queue
    {
        private static Queue __instance;

        public static Queue getInstance()
        {
            if (__instance == null)
                __instance = new Queue();
            return __instance;
        }

        private ObservableCollection<QueueItem> queue;


        public Queue()
        {
            this.queue = new ObservableCollection<QueueItem>();
        }

        public ObservableCollection<QueueItem> GetAll()
        {
            return this.queue;
        }

        public QueueItem GetQueueItemByPath(string path)
        {
            return queue.Where(x => x.GetMusicPath() == path).FirstOrDefault();
        }
        public void Add(string path)
        {
            int id = this.queue.Count;
            this.queue.Add(new QueueItem(id, path));
        }
    }
}
