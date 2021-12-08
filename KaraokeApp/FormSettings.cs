using NAudio.CoreAudioApi;
using Shazam;
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
    public partial class FormSettings : Form
    {
        public static FormSettings __instance;
        public static FormSettings getInstance()
        {
            if (__instance == null)
                __instance = new FormSettings();
            return __instance;
        }
        private static readonly MMDeviceEnumerator Enumerator = new MMDeviceEnumerator();
        public FormSettings()
        {
            InitializeComponent();
            int index = 0;
            var devices = Enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active).Select((device, i) => {
                string deviceType;
                switch (device.DataFlow)
                {
                    case DataFlow.Capture:
                        deviceType = "IN - ";
                        break;
                    case DataFlow.Render:
                        deviceType = "OUT - ";
                        break;
                    default:
                        deviceType = "UNK - ";
                        break;
                }
                if(!String.IsNullOrEmpty(Properties.Settings.Default.DeviceId)
                && device.ID == Properties.Settings.Default.DeviceId)
                {
                    index = i;
                }
                return new Device(device.ID, deviceType + device.FriendlyName);
            }).ToArray();
            cbxDevice.Items.AddRange(devices);
            cbxDevice.SelectedIndex = index;
        }

        private void cbxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceId = ((Device)cbxDevice.SelectedItem).DeviceId;
        }
    }
}
