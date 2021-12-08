using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    class Queue
    {
        private static Queue __instant;

        public static Queue getInstant()
        {
            if (__instant == null)
                __instant = new Queue();
            return __instant;
        }

        private ObservableCollection<string> queue;

        public Queue()
        {
            this.queue = new ObservableCollection<string>();
        }

        public ObservableCollection<string> GetAll()
        {
            return this.queue;
        }

        public void Add(string path)
        {
            this.queue.Add(path);
        }
    }
}
