using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    class RecentlyMusics
    {
        private static RecentlyMusics __instance;

        public static RecentlyMusics getInstance()
        {
            if (__instance == null)
                __instance = new RecentlyMusics();
            return __instance;
        }

        private ObservableCollection<string> recentlyMusics;

        public RecentlyMusics()
        {
            this.recentlyMusics = new ObservableCollection<string>();
        }

        public ObservableCollection<string> GetAll()
        {
            return this.recentlyMusics;
        }

        public void Add(string path)
        {
            this.recentlyMusics.Add(path);
        }
    }
}
