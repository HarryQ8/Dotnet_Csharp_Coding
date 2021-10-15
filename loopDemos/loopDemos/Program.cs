using System;
using System.Collections.Generic;

namespace loopDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //SumFrom1To100();
            //InputQuitToStop();
            //SumFrom1To100UseFor();
            BreakAndContinue();
            Console.ReadKey();
        }


        #region "循环结构示例"
        /// <summary>
        /// 使用While循环计算"1+2+3+..+100=?"
        /// </summary>
        static void SumFrom1To100()
        {
            //此变量将用于保存求和结果
            int sum = 0;
            //此变量将作为循环变量
            int counter = 1;

            while (counter <= 100)
            {
                sum += counter;
                //代码简写为
                //sum=sum+counter;
                counter++;
            }
            Console.WriteLine(sum);

        }
        #endregion


        ///<summary>
        ///使用特殊值结束输入
        ///End input with special value
        /// </summary>
        static void InputQuitToStop()
        {
            string userInput = "";
            while (userInput.ToLower() != "quit")   //将所得的字符串全部转成小写
            {
                Console.WriteLine("\n不断输入字符串，回车结束一次输入。当不在运行程序的时候，输入quit:");
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput) == false)
                {
                    Console.WriteLine("Your input:{0}", userInput);
                }
            }
            Console.WriteLine("\n-------------");
            Console.WriteLine("\n检测到quit命令，循环终止，按任意键退出...");
        }


        ///<summary>
        ///使用for循环计算"1+2+3+...+100=?"
        /// </summary>
        static void SumFrom1To100UseFor()
        {
            //此变量将用于保存求和结果
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            //输出结果
            Console.WriteLine(sum);



            // we can output the range of number value in C#
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 5;
            Console.WriteLine($"An example of overflow: {what}");
        }


        /// <summary>
        /// 理解Break和Contiue的不同作用
        /// </summary>
        static void BreakAndContinue()
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    //Switch the comments of the following two sentences to experience their different functions.
                    //continue;
                    break;
                }
                Console.WriteLine("the number of cycles is {0}.", i);
            }
        }


        /// <summary>
        /// 循环遍历集合中的每一个数据
        /// </summary>
        static void ForEachDataCollection()
        {
            Console.WriteLine("遍历整数集合:\n");

            var IntValues = new List<int>() { 1, 2, 3, 4 };
            foreach(var value in IntValues)
            {
                //取消以下注释，尝试在便利过程中从集合中移除数据，
                //将会遇到"System.InvalidOperationException"异常
                //if(v)
            }
        }







    }
}


