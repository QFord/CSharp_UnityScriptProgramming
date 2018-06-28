using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 省略name参数
            TestMethod(2, 14);
            // 省略了y和name参数
            TestMethod(2);

            // 为部分实参指定名称，使用命名实参只省略第二个参数
            TestMethod(2, name : "Hello");
            // 为所有实参指定名称
            TestMethod(x: 2, y: 20, name: "Hello");
            Console.Read();
        }

        // 带有可选参数的方法
        static void TestMethod(int x, int y = 10, string name = "LearningHard")
        {
            Console.WriteLine("x={0} y={1} name={2}", x, y, name);
        }
    }
}
