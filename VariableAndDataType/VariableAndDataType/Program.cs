using System;
using System.Collections.Generic;
using System.Dynamic;

namespace VariableAndDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("“变量、数据类型与表达式”示例\n");

            //UseLargeNumbers();

            // DefaultValues();

            //DefineVariable();

            //DynamicTypeDemo();

            //StringOrstring();

            //UseVarKeyWord();

            PrintDataTypeLength();

            //WhyTheResultIsWrong();

            ///CompareTwoFloatNumber();

            //StringAndNumberType();

            //UseOperator();

            //UseExpression();

            Console.ReadKey();
        }

        /// <summary>
        /// 大的数字，可以使用下划线随意分隔（C# 7）
        /// </summary>
        private static void UseLargeNumbers()
        {
            long distanceToSunFromEarth = 149_600_000;
            //输出：149600000
            Console.WriteLine(distanceToSunFromEarth);


            //定义一个二进制的数值
            int b = 0b1010_1011_1100_1101_1110_1111;
            //输出：11259375
            Console.WriteLine(b);
        }

        /// <summary>
        /// 变量的定义与变量的类型
        /// </summary>
        static void DefineVariable()
        {
            int intValue = 100;
            long longValue = 100l;
            double doubleValue = 100.5d;
            float floatValue = 100.5f;

            Console.WriteLine(intValue.GetType());  //System.Int32
            Console.WriteLine(longValue.GetType()); //System.Int64
            Console.WriteLine(doubleValue.GetType()); //System.Double
            Console.WriteLine(floatValue.GetType());  //System.Single

            Console.WriteLine(intValue.GetType() == typeof(int));  //true
        }

        /// <summary>
        /// C#中定义字符串，到底是用“String”还是“string”？
        /// </summary>
        static void StringOrstring()
        {
            String str1 = "Hello";
            string str2 = "World";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());
            Console.WriteLine(typeof(String) == typeof(string));
        }

        /// <summary>
        /// 隐式类型变量定义
        /// </summary>
        static void UseVarKeyWord()
        {
            var value = 100;
            Console.WriteLine(value.GetType());

            var dic = new Dictionary<string, List<int>>();
            Console.WriteLine(dic.GetType());

        }

        /// <summary>
        /// 可以动态添加成员的数据类型
        /// </summary>
        static void DynamicTypeDemo()
        {
            //dynamic是一种“神奇”的数据类型，它所定义的变量，可以动态地添加成员
            dynamic obj = new ExpandoObject();

            //给它添加一个int类型的属性
            obj.intValue = 100;

            //给它添加一个方法
            Action<int> act = (value) => Console.WriteLine(value);
            obj.printValue = act;

            //调用新添加的方法，输出新添加的属性值
            obj.printValue(obj.intValue); //100
        }

        /// <summary>
        /// 数据类型的默认值
        /// </summary>
        static void DefaultValues()
        {
            //数字类型（整型或浮点型）的默认值是0
            Console.WriteLine(default(int));
            //字符串类型的默认值是空引用，用null这个关键字来表示
            Console.WriteLine(default(string) == null);//输出：True
            //字符类型的默认值是'\0'
            Console.WriteLine(default(char) == '\0');//输出：True
            //布尔类型的默认值是False
            Console.WriteLine(default(bool));
            //表示日期的DateTime类型的默认值是 0001/1/1 0:00:00
            Console.WriteLine(default(DateTime));
        }

        /// <summary>
        /// 了解特定数据类型变量所占的内存单元多少
        /// </summary>
        static void PrintDataTypeLength()
        {
            Console.WriteLine("int类型占用：{0}字节", sizeof(int));    //4
            Console.WriteLine("long类型占用：{0}字节", sizeof(long));  //8
            Console.WriteLine("float类型占用：{0}字节", sizeof(float));    //4
            Console.WriteLine("double类型占用：{0}字节", sizeof(double));  //8


        }


        /// <summary>
        /// 数值类型之间的状态转换
        /// </summary>
        static void NumberTypeConvert()
        {
            int intValue = 100;
            long longValue = 100l;
            double doubleValue = 100.5d;
            float floatValue = 100.5f;

            //“小的”可以直接赋给“大的”
            longValue = intValue;
            doubleValue = intValue;
            doubleValue = floatValue;

            //“大的”要赋值给“小的”，必须进行“类型转换”，这就是强制转换
            intValue = (int)longValue;
            intValue = (int)doubleValue;

            //即使占用相同大小的内存，因为类型不同，也必须进行“类型转换”
            intValue = (int)floatValue;
        }


        /// <summary>
        /// 字符串与数值类型间的转换
        /// </summary>
        static void StringAndNumberType()
        {
            string strValue = "100";

            //string -->数值类型

            //方法一：使用Parse方法
            int intValue = int.Parse(strValue);
            double doubleValue = double.Parse(strValue);
            //方法二：使用Convert类
            intValue = Convert.ToInt32(strValue);
            doubleValue = Convert.ToDouble(strValue);

            //数值类型 -->string

            //方法一：调用ToString()方法
            strValue = intValue.ToString();
            //方法二：将数值类型变量与一个空字符串相加
            strValue = doubleValue + "";

        }


      
    }
}
