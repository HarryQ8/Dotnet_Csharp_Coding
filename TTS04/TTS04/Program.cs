using System;
using SpeechLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TTS04
{
    class Program
    {
        public static void TTSSpeech(string text)
        {
            SpVoice voice = new SpVoice();
            voice.Rate = 1;
            voice.Volume = 70;
            voice.Voice = voice.GetVoices().Item(0);
            voice.Speak(text);
            Thread.CurrentThread.Abort();
        }

        public static void ThreadTTSStart(string s)
        {
            Thread thread = new Thread(() => TTSSpeech(S));
            thread.Start();
        }
        //public static Main(string[] arg)
        //{

        //}
    }
}
