using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace KaraokeApp.data
{
    class Lyric
    {
        public string lyricString { get; set; }
        public long timePoint { get; set; }


        public Lyric(string _lyric, long _timePoint)
        {
            this.lyricString = _lyric;
            this.timePoint = _timePoint;
        }


    }
    
    class Word
    {
        public string data { get; set; }
        public long startTime { get; set; }
        public long endTime { get; set; }

        public Word(string _karaString, long _startTime, long _endTime)
        {
            this.data = _karaString;
            this.startTime = _startTime;
            this.endTime = _endTime;
        }   
    }



    class KaraSetence
    {
        public List<Word> words;

        public KaraSetence(List<Word> _karaList)
        {
            this.words = _karaList;
        }
        public KaraSetence()
        {
            words = new List<Word>();
        }
    }
    

      class LyricUtil
      {
        
        private static List<Lyric> lyricList;
        private static List<KaraSetence> karaSetences;
        public static List<Lyric> ReadLRCFile(string filePath)
        {

            lyricList = new List<Lyric>();
            if(File.Exists(filePath))
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    string ln;

                    while((ln = file.ReadLine()) != null)
                    {
                        AnalyzeLRC(ln);
                    }
                }
            }            
            return lyricList;
        }
        

        public static List<KaraSetence> ReadKaraFile(string filePath)
        {
            karaSetences = new List<KaraSetence>();
            if(File.Exists(filePath))
            {
                using(StreamReader file = new StreamReader(filePath))
                {
                    string karas = File.ReadAllText(filePath);

                    // Due to Json Object don't have key value
                    Newtonsoft.Json.Linq.JArray karaS = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(karas);

                    for(int sentenceIndex = 0; sentenceIndex < karaS.Count; sentenceIndex++)
                    {
                        KaraSetence sentence = new KaraSetence();

                        // Words in sentences 
                        Newtonsoft.Json.Linq.JArray wordList =(Newtonsoft.Json.Linq.JArray)karaS[sentenceIndex]["words"];
                        for(int wordIndex = 0; wordIndex < wordList.Count; wordIndex++)
                        {
                            Word wordToken = JsonConvert.DeserializeObject<Word>(wordList[wordIndex]
                                .ToString());

                            sentence.words.Add(wordToken);
                        }

                        karaSetences.Add(sentence);
                    }

                }
            }

            return karaSetences;
        }

        public static string AnalyzeLRC(string _line)
        {
            try
            {
                int pos1 = _line.IndexOf("[");
                int pos2 = _line.IndexOf("]");
                

                string timeString = _line.Substring(pos1 +1, pos2 -1);
                string strLineRemaining = _line;

                // Lyric begin with digit
                if(Char.IsDigit(timeString[0]))
                {
                    //Lyric
                    strLineRemaining = _line.Substring(pos2 + 1);
                    long mPointTime = TimeToLong(timeString);


                    
                    Lyric mLRC = new Lyric(strLineRemaining, mPointTime);
                    lyricList.Add(mLRC);
                    return strLineRemaining;
                }
                return "";
            }
            catch
            {

                return "";
            }
         
        }

        public static long TimeToLong(string _time)
        {
            try
            {

                
                string[] mTime = _time.Split(':');  // Format xx:xx.xx


                int min = Int32.Parse(mTime[0]); // Parse To Minute

                string[] sTime = mTime[1].Split('.');// Format xx.xx

                //Parse to Second, milisecond
                int sec = Int32.Parse(sTime[0]);
                int mil = Int32.Parse(sTime[1]);

                return min * 60 * 1000 + sec * 1000 + mil * 10;
            }
            catch
            {

                return -1;
            }
        }
    }

}
