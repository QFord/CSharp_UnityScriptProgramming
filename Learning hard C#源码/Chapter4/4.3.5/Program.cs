using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        // 析构函数
        ~Person()
        {
            Console.WriteLine("析构函数被调用了");
        }
    }
}
