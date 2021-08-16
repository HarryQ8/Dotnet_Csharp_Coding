using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;


namespace TTS03
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer ssh = new SpeechSynthesizer();
            string content = "您好，欢迎语音转换功能。请输入您的昵称";
            ssh.Speak(content);
            string input = Console.ReadLine();
            Console.WriteLine($"您好：{input}");
            ssh.Speak($"欢迎 {input} 使用语音功能");
            ssh.Speak("你好北京");
            Console.ReadKey();
            Console.WriteLine(ssh.GetInstalledVoices());
            Console.ReadKey(true);
        }
    }
}
