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
        private static readonly MMDeviceEnumerator Enumerator = new MMDeviceEnumerator();
        public static Device selectedDevice { get; set; }
        public FormSettings()
        {
            InitializeComponent();
            var devices = Enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active).Select(device => {
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
                return new Device(device.ID, deviceType + device.FriendlyName);
            }).ToArray();
            cbxDevice.Items.AddRange(devices);
            cbxDevice.SelectedIndex = 0;
            selectedDevice = (Device)cbxDevice.SelectedItem;
        }

        private void cbxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDevice = (Device)cbxDevice.SelectedItem;
        }
    }
}
