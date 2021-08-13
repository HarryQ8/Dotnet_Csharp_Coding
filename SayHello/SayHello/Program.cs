using System;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            TestConsoleProperty();

            Console.Beep();

            Console.WriteLine("程序暂停，敲任意键继续……");
            Console.ReadKey(true);

            TestInputAndOutput();

            TestStringInterpolation();
            
            Console.WriteLine("程序运行完毕，敲任意键退出……");
            Console.ReadKey(true);
        }

        /// <summary>
        /// 展示Console类相关属性的用法
        /// </summary>
        private static void TestConsoleProperty()
        {
            Console.WriteLine("\n展示控制台文本颜色属性的用法\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("前景色为绿色");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("蓝色前景，白色背景");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("黑色背景红色前景");
            //还原为白色的前景,黑色的背景
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //加一个空行
            Console.WriteLine();
        }

        /// <summary>
        /// 测试控制台窗口的输入与输出功能
        /// </summary>
        private static void TestInputAndOutput()
        {
            Console.Write("请输入一个字串:");
            //等待用户从键盘输入信息，敲回车后，
            //用户输入的信息保存在userInput变量中 
            String userinput = Console.ReadLine();
            //输出一个空行
            Console.WriteLine();
            //WriteLine()方法输出变量的内容，自动换行
            //Write()方法则不会换行
            Console.WriteLine("\t用户输入了: {0},共有{1} 个字符\n",
                userinput, userinput.Length);
        }

        /// <summary>
        /// 展示C# 6中引入的字符串插补特性
        /// </summary>
        private static void TestStringInterpolation()
        {
            DateTime date = DateTime.Now;
            //输出：当前日期为2020年7月23日
            Console.WriteLine($"当前日期为{date.Year}年{date.Month}月{date.Day}日");

        }
    }
}
