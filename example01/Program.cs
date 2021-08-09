using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass hello = new Myclass();
            hello.SayHello();
            
        }
    }

    class Myclass
    {
        private int x;
        public void SayHello()
        {
            Console.WriteLine("Hello world");
        }
    }
}
