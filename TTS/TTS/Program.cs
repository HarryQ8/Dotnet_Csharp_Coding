using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TTS
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
            //voice.Rate = -1; //设置语速,[-10,10]
            //voice.Volume = 100; //设置音量,[0,100]
            //voice.SpeakAsync("Hellow Word");  //播放指定的字符串,这是异步朗读

            //下面的代码为一些SpeechSynthesizer的属性，看实际情况是否需要使用
            //voice.Dispose();  //释放所有语音资源
            //voice.SpeakAsyncCancelAll();  //取消朗读
            //voice.Speak("Hellow Word");  //同步朗读
            //voice.Pause();  //暂停朗读
            //voice.Resume(); //继续朗读

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            SpeechSynthesizer ssh = new SpeechSynthesizer();
            string content = "Hello,Please input your string:";
            ssh.Speak(content);
            
            
            
            
            string input = Console.ReadLine();
            Console.WriteLine($"Hello：{input}");
            ssh.Speak($"Welcome {input} using voice function.");

        }
    }
}
