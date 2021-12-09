using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.data
{
    public class Recorder
    {
        WaveIn sourceStream;
        WaveFileWriter waveWriter;
        readonly string FilePath;
        readonly string FileName;
        readonly int InputDeviceIndex;
        public bool isPaused;


        public Recorder(string filePath, string fileName, int deviceID)
        {
            this.FileName = fileName;
            this.FilePath = filePath;
            this.InputDeviceIndex = deviceID;
        }



        public void StartRecording()
        {
            sourceStream = new WaveIn
            {
                DeviceNumber = this.InputDeviceIndex,
                WaveFormat = new WaveFormat(44100,
                WaveIn.GetCapabilities(this.InputDeviceIndex).Channels)
            };

            sourceStream.DataAvailable += this.SourceStreamDataAvailable;

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            isPaused = false;
            waveWriter = new WaveFileWriter(FilePath + FileName, sourceStream.WaveFormat);
            sourceStream.StartRecording();
        }

        public void SourceStreamDataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;
            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }


        public void RecordEnd()
        {
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (this.waveWriter == null)
            {
                return;
            }
            this.waveWriter.Dispose();
            this.waveWriter = null;
        }



        public void PauseRecording()
        {
            if (isPaused == false)
            {
                sourceStream.DataAvailable -= SourceStreamDataAvailable;
                isPaused = true;
            }
        }
        

        public void ResumeRecording()
        {
            if(isPaused == true)
            {
                sourceStream.DataAvailable += SourceStreamDataAvailable;
                isPaused = false;
            }
        }
    }
}
