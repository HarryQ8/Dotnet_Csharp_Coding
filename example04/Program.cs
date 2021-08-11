using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example04
{
    class Program
    {
        struct Student  // 结构类型
        {
            public int age;
            public string name;

        }
        enum DayOFTime:long //  枚举类型   
        {
            Morning=9,
            Noon,
            Afternoon
        }

        static void Main(string[] args)
        {
            Student s1; //  新建一个学生s1
            s1.age = 18;
            s1.name = "Harry";
            Student[] ss = new Student[100];    //结构构造100个学生的信息

            DayOFTime d1;
            d1 = DayOFTime.Noon;
        }
    }
}
