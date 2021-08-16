using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n展示控制台文本颜色属性的的用法");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("前景颜色为绿色");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("蓝色的前景，白色的背景");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("黑色背景红色前景");

            //  还原为白色的前景，黑色的背景
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //  加一个空行
            Console.WriteLine();


            Console.WriteLine("Please input a string line :");
            string userinput = Console.ReadLine();
            Console.WriteLine("\tuser's input:{0},there are totally {1} character\n", userinput, userinput.Length);

            Console.ReadKey(true);
        }
    }
}
