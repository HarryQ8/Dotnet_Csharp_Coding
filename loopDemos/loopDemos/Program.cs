using System;

namespace loopDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            SumFrom1To100();
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
    }
}


