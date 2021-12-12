using KaraokeApp.data;
using KaraokeApp.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class FormList : Form
    {
        private UCSong currentSongActivedItem;
        private UCRecord currentRecordActivedItem;
        private List<Song> songList;
        private List<Record> recordList;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handlerParam = base.CreateParams;
                handlerParam.ExStyle |= 0x02000000;
                return handlerParam;
            }
        }
        public FormList()
        {
            InitializeComponent();

            flowPNLListSong.AutoScroll = false;

            flowPNLListSong.VerticalScroll.Maximum = 0;
            flowPNLListSong.VerticalScroll.Visible = false;
            flowPNLListSong.HorizontalScroll.Maximum = 0;
            flowPNLListSong.HorizontalScroll.Visible = false;

            flowPNLListSong.AutoScroll = true;
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            songList = DataPool.GetSongList();
            recordList = DataPool.GetRecordList();
            UCSong songItem = null;
            foreach (Song songIndex in songList)
            {
                songItem = new UCSong(songIndex);
                songItem.Dock = DockStyle.Top;
                flowPNLListSong.Controls.Add(songItem);
            }
        }


        public void AddSongToQueue(UCSong currentItem, Song _songItem)
        {
            if (currentSongActivedItem != null)
            {
                //currentMusic.PauseMusic();
            }
            currentSongActivedItem = currentItem;
            ((FormMain)(this.Parent.Parent.Parent.Parent)).AddQueueItem(_songItem);
        }

        public void PlayRecord(UCRecord currentItem, string filePath)
        {
            if (currentRecordActivedItem != null)
            {
                //currentMusic.PauseMusic();
            }
            ((FormMain)(this.Parent.Parent.Parent)).PlayMusicInDB(filePath);
        }

        public void PlayKaraoke(UCSong currentItem)
        {
            if (currentSongActivedItem != null)
            {
                //currentMusic.PauseMusic();
            }
            currentSongActivedItem = currentItem;
            ((FormMain)(this.Parent.Parent.Parent)).PlayingKaraoke();
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {

            flowPNLListSong.Controls.Clear();
            if (cbType.Text == "Record")
            {
                foreach (Record recordIndex in recordList)
                {
                    if (recordIndex.name.ToLower().Contains(txtSeach.Text.ToLower()))
                    {
                        flowPNLListSong.Controls.Add(new UCRecord(recordIndex));
                    }
                }
            }
            else
            {
                foreach (Song songIndex in songList)
                {
                    if (songIndex.GetTitle().ToLower().Contains(txtSeach.Text.ToLower()))
                        flowPNLListSong.Controls.Add(new UCSong(songIndex));
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowPNLListSong.Controls.Clear();
            switch (cbType.Text)
            {
                case "Both (Except Record)":
                    foreach (Song songIndex in songList)
                    {
                        flowPNLListSong.Controls.Add(new UCSong(songIndex));
                    }
                    break;
                case "Song":
                    foreach (Song songIndex in songList)
                    {
                        if (songIndex.GetBeatLink() == "" ||
                            songIndex.GetBeatLink() == null)
                            flowPNLListSong.Controls.Add(new UCSong(songIndex));
                    }
                    break;
                case "Karaoke":
                    foreach (Song songIndex in songList)
                    {
                        if (songIndex.GetBeatLink() != "" &&
                            songIndex.GetBeatLink() != null)
                            flowPNLListSong.Controls.Add(new UCSong(songIndex));
                    }
                    break;
                case "Record":
                    foreach (Record recordIndex in recordList)
                    {
                        flowPNLListSong.Controls.Add(new UCRecord(recordIndex));
                    }
                    break;
            }
        }

        public void SwitchMode(bool isDark)
        {
            this.BackColor = isDark ? FormMain.clrBackgroundDark : FormMain.clrBackgroundLight;
            pnlListBorder.BorderColor = pnlListContent.BackColor = isDark ? FormMain.clrCardDark : FormMain.clrCardLight;
        }
    }
}
