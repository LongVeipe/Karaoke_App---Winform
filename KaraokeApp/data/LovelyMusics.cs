using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    class LovelyMusics
    {
        private static LovelyMusics __instant;

        public static LovelyMusics getInstant()
        {
            if (__instant == null)
                __instant = new LovelyMusics();
            return __instant;
        }

        private ObservableCollection<string> lovelyMusics;

        public LovelyMusics()
        {
            this.lovelyMusics = new ObservableCollection<string>();
        }

        public ObservableCollection<string> GetAll()
        {
            return this.lovelyMusics;
        }

        public void Add(string path)
        {
            this.lovelyMusics.Add(path);
        }

        public void Remove(string path)
        {
            this.lovelyMusics.Remove(path);
        }
    }
}
