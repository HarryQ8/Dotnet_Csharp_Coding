using System;

namespace IfAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            //CompareValue(11);
            //CompareValue(3);
            //IfAndElse(9);


            //HowOldAreYou(100);
            //HowOldAreYou(90);
            //HowOldAreYou(60);
            //HowOldAreYou(25);
            //HowOldAreYou(15);
            //HowOldAreYou(5);
            //HowOldAreYou(1);

            DoYouPass();

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


        /// <summary>
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


        #region "嵌套语句"
        /// <summary>
        ///用于展示嵌套的条件判断语句
        /// </summary>
        #endregion

        static void HowOldAreYou(int age)
        {
            if (age > 60)
            {
                Console.WriteLine("{0} ages, the old.", age);
            }
            else
            {
                if (age > 40)
                {
                    Console.WriteLine("{0} ages, the middle", age);
                }
                else
                {
                    if (age > 18)
                    {
                        Console.WriteLine("{0} ages, the younger", age);
                    }
                    else
                    {
                        if (age > 10)
                        {
                            Console.WriteLine("{0} ages, the juvenile", age);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///另一种是用if进行并列就可以更改上面的嵌套
        /// </summary>


        #region "Switch"
        /// <summary>
        /// 学习使用Switch
        /// </summary>
        #endregion
        static void DoYouPass()
        {
            Console.Write("请输入你的考试成绩：");
            string UserInput = Console.ReadLine();
            int score = int.Parse(UserInput);
            switch (score / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("你是学霸");
                    break;
                case 8:
                    Console.WriteLine("你的成绩还不错");
                    break;
                case 7:
                    Console.WriteLine("你的成绩可归于‘路人甲’一类");
                    break;
                case 6:
                    Console.WriteLine("哥们，小心点！");
                    break;
                default:
                    Console.WriteLine("杯具时刻");
                    break;
            }
        }


    }
}
