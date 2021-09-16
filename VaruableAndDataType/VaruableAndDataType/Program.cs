using System;

namespace VaruableAndDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //DefineVariable();
            //StringOrstring();
            //UseVarKeyWord();
            //UseOperator();
            Expression();
            Console.ReadKey();
        }

        #region "变量与数据类型"
        /// <summary>
        /// 变量的定义与变量的类型
        /// </summary>
        #endregion
        static void DefineVariable()
        {
            int intValue = 100;
            long longValue = 100L;
            double doubleValue = 100.5d;
            float folatValue = 100.5f;

            Console.WriteLine(intValue.GetType());
            Console.WriteLine(longValue.GetType());
            Console.WriteLine(doubleValue.GetType());
            Console.WriteLine(folatValue.GetType());

            Console.WriteLine(intValue.GetType() == typeof(int));
         
        }


        #region "C#中字符串定义"
        ///<summary>
        ///C#中是用String还是用string
        /// </summary>
        /// 
        #endregion
        static void StringOrstring()
        {
            String str1 = "Hello";
            string str2 = "Hello";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());
            Console.WriteLine(typeof(string) == typeof(String));
        }


        #region "隐式定义变量"
        ///<summary>
        ///隐式类型变量定义
        /// </summary>
        #endregion
        static void UseVarKeyWord()
        {
            var value = 100;
            Console.WriteLine(value.GetType());

            var value2 = "Hello";
            Console.WriteLine(value2.GetType());

        }


        #region "变量占有的内存大小"
        ///<summary>
        ///了解特定的数据类型变量所占的内存单元大小
        /// </summary>
        #endregion

        static void PrintDataTypeLength()
        {
            Console.WriteLine("int类型占用：{0}字节", sizeof(int));        //4
            Console.WriteLine("long类型占用：{0}字节", sizeof(long));      //8
            Console.WriteLine("float类型占用：{0}字节", sizeof(float));    //4
            Console.WriteLine("double类型占用：{0}字节", sizeof(double));  //8

            int intValue = 100;
            long longValue = 100L;
            double doubleValue = 100.5d;
            float floatValue = 100.5f;

            longValue = intValue;
            doubleValue = intValue;
            doubleValue = floatValue;

            intValue = (int)longValue;
            intValue = (int)doubleValue;

            floatValue = (float)doubleValue;

            floatValue = intValue;
            intValue = (int)floatValue;
        }


        #region "字符串与数值类型之间转换"
        ///<summary>
        ///字符串从用户窗口获取，再进行类型转换到数值类型
        /// </summary>
        #endregion
        static void StringAndNumberType()
        {
            string strValue = "100";

            int intValue = int.Parse(strValue);
            double doubleValue = double.Parse(strValue);

            intValue = Convert.ToInt32(strValue);
            doubleValue = Convert.ToDouble(strValue);

            strValue = intValue.ToString();
            strValue = doubleValue.ToString();
            strValue = 200.ToString();

            strValue = intValue + "";

        }


        #region "运算符与表达式"
        /// <summary>
        /// 使用运算符
        /// </summary>
          static void UseOperator()
        {
            // + _ * / , ()
            double result = ((5 + 3) * 2 - 7) / 6;
            Console.WriteLine(result);

            int value = 9 % 4;
            Console.WriteLine(value);

            int index = 1;
            Console.WriteLine(index++);
            Console.WriteLine(++index);

        }

        ///<summary>
        ///使用表达式
        /// </summary>
        static void Expression()
        {
            int value = 100;
            Console.WriteLine(value * 2);
        }
        #endregion
    }
}
 