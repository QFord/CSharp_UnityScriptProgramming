using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._1
{
    class Program
    {
        static void Main(string[] args)
        {
           TestMethod(2, 4, "Hello");
           TestMethod(2, 14);
           TestMethod(2);
           Console.Read();
        }
        // 带有可选参数的方法
        static void TestMethod(int x, int y = 10, string name = "LearningHard")
        {
            Console.WriteLine("x={0} y={1} name={2}", x, y, name);
        }
    }
}
