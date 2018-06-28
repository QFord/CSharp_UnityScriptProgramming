using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticConstructor
{
    class Person
    {
        // 静态字段
        private static string name;
        int a;

        // 静态构造函数，仅执行一次
        static Person()
        {
            Console.WriteLine("静态构造函数被调用了");
            name = "Learning Hard";
        }

        // 静态属性
        public static string Name
        {
            get { return name; }
        }
    }

    class Program
    {
        // 演示静态构造函数的使用
        static void Main(string[] args)
        {
            Person person = new Person();//
            // 输出Name属性的值
            //Console.WriteLine(Person.Name);
            //Console.WriteLine(Person.Name);
            Console.Read();
        }
    }
}
