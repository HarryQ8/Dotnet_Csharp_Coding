using System;

namespace VaruableAndDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //DefineVariable();
            //StringOrstring();
            UseVarKeyWord();
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
            long longValue = 100l;
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
        }





    }
}
