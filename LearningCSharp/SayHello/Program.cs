using System;


namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConsoleProperty();
            Console.WriteLine("Hello World!");
            TestInputAndOutput();

            //Console.WriteLine("First ReadKey()");
            //Console.ReadKey();
            //Console.WriteLine("Second ReadKey()");
            //Console.ReadKey(true);
            //Console.WriteLine("Final ReadKey()");
            //Console.ReadKey();



            Console.Beep();
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
            
        }

        #region "设置控制台颜色以及标题"
        /// <summary>
        /// 使用console类中的对应方法可以实现
        /// </summary>
        static void TestConsoleProperty()
        {
            //Console.Title = "Say Hello";
            Console.Title = "Current Time" + DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        #endregion


        #region "在控制台中输入数据"
        /// <summary>
        /// 在控制台中写入或者大印出相对于的信息
        /// </summary>
        static void TestInputAndOutput()
        {
            Console.Write("Please input a string:");

            //input
            string userInput = Console.ReadLine();

            //output
            Console.WriteLine("user input:\t{0}. \nthe length of string:{1}." ,userInput,userInput.Length);
        }
        #endregion




    }
}
