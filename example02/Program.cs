using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = Console.ReadLine();  //输入一个字符串
            //int x = Convert.ToInt32(s); //  进行强制类型转换
            //s = Console.ReadLine(); //  输入一行字符
            //int y = Convert.ToInt32(s); //  强制类型转换
            //int z = x + y;  //  进行两个数字相加
            //Console.WriteLine(z);   //  从控制台输出即可

            //string s = console.readline();  //输入一个字符串
            //int x = convert.toint32(s); //  进行强制类型转换
            //s = console.readline(); //  输入一行字符
            //int y = convert.toint32(s); //  强制类型转换
            //int z = x + y;  //  进行两个数字相加
            //console.writeline(z);   //  从控制台输出即可


            //在一行中输入多个数据

            string s2 = Console.ReadLine();
            string[] ss2 = s2.Split(' ');
            double[] a = new double[ss2.Length];
            double sum = 0;
            for (int i = 0; i < ss2.Length; i++)
            {
                a[i] = Convert.ToDouble(ss2[i]);
                sum = sum + a[i];
            }
            Console.WriteLine(sum);

            //带格式进行输出

            Console.WriteLine("和是{0},平均数{1}",sum,sum/4);    // 带格式的占位符进行格式输出
            int
        }
    }
}
