
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
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



        private string micFile;
        readonly int InputDeviceIndex;



        public bool isPaused;
        private TimeSpan startPosition;
        private TimeSpan endPosition;


        public Recorder(string filePath, string fileName, int deviceID)
        {
            this.FileName = fileName;
            this.FilePath = filePath;
            this.InputDeviceIndex = deviceID;
            this.micFile = FilePath + "mic" + FileName;
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
            waveWriter = new WaveFileWriter(micFile, sourceStream.WaveFormat);
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
    
        private IWaveProvider CutAudio(WaveStream wave)
        {
            ISampleProvider sourceProvider = wave.ToSampleProvider();

            // Take audio from startPosition to endPosition
            OffsetSampleProvider start = new OffsetSampleProvider(sourceProvider)
            {
                SkipOver = startPosition,
                Take = (endPosition - startPosition)
            };

            return (start.ToWaveProvider());
        }


        public void MixingAudio(string pathFile)
        {
            AudioFileReader reader = new AudioFileReader(pathFile);
            

            // File Mic and File cutted beat
            IWaveProvider wave = CutAudio(reader);
            IWaveProvider wave1 = new AudioFileReader(micFile);

            var mixer = new MixingWaveProvider32(new[]
                { wave, wave1});

            var outFormat = new WaveFormat(44100, 16, 1);
            var resampler = new MediaFoundationResampler(mixer, outFormat);

            // Create and save File in DB
            WaveFileWriter.CreateWaveFile(FilePath + FileName, resampler);
            DatabaseHelper.SaveRecord(new Record(FileName,
                FilePath + FileName));
        }


        public void SetStartPosition(TimeSpan _startPosition)
        {
            this.startPosition = _startPosition;
        }

        public void SetEndPosition(TimeSpan _endPosition)
        {
            this.endPosition = _endPosition;
        }


        public void DeleteMicFile()
        {
            // Remove Mic File after it's being used
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(micFile);
        }
    }
}
