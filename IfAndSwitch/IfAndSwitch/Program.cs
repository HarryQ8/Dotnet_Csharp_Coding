using System;

namespace IfAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            //CompareValue(11);
            //CompareValue(3);
            IfAndElse(9);

            Console.ReadKey(true);
        }


        ///<summary>
        ///简单的if...else... 结构
        /// </summary>
        /// <param name="value"></param>
        static void CompareValue(int value)
        {
            if (value > 10)
            {
                Console.WriteLine("{0}比10大", value);
            }
            else
            {
                Console.WriteLine("{0}比10小", value);
            }
        }

        ///<summary>
        ///if and else 的就近配套原则
        /// </summary>

        static void IfAndElse(int value)
        {
            //int value = 90;
            if (value > 10)
            {
                Console.WriteLine("{0}大于10", value);
                if (value % 10 == 0)
                {
                    Console.WriteLine("{0}是10的倍数", value);
                }
            }
            else   //前面有两个if，我和哪个配对？
            {
                Console.WriteLine("{0}小于等于10", value);
            }
        }  
    }
}
