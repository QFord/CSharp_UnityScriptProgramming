using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPerson tp = new TestPerson("QFord");
            Console.WriteLine("name = " + tp.Name);

            Console.Read();
        }
    }
}
