using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
            voice.Rate = -1; //设置语速,[-10,10]
            voice.Volume = 100; //设置音量,[0,100]
            voice.SpeakAsync("Hellow Word");  //播放指定的字符串,这是异步朗读

            //下面的代码为一些SpeechSynthesizer的属性，看实际情况是否需要使用
            voice.Dispose();  //释放所有语音资源
            voice.SpeakAsyncCancelAll();  //取消朗读
            voice.Speak("Hellow Word");  //同步朗读
            voice.Pause();  //暂停朗读
            voice.Resume(); //继续朗读

        }
    }
}
