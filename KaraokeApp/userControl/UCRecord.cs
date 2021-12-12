using KaraokeApp.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.userControl
{
    public partial class UCRecord : UserControl
    {
        private Record recordItem;
        public UCRecord()
        {
            InitializeComponent();
        }
        public UCRecord(Record _record)
        {
            InitializeComponent();
            this.recordItem = _record;
            lblRecordName.Text = recordItem.name;
        }

        private void btnPlayStream_Click(object sender, EventArgs e)
        {
            string absolutePath = Path.GetFullPath(recordItem.GetStreamLink());
            ((FormList)(this.Parent.Parent.Parent.Parent))
                .PlayRecord(this, absolutePath);
            Song newSong = null;
            DataPool.UpdateCurrentSong(newSong);
        }
    }
}
