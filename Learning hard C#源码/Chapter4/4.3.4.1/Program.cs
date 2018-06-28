using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    /// <summary>
    /// 类定义
    /// </summary>
    class Person
    {
        // 字段
        private string name;

        // 只读属性
        public string Name
        {
            get
            {
                return name;
            }
        }

        // 无参数的实例构造函数
        public Person()
        {
            Console.WriteLine("实例构造函数被调用了");
            name = "Learning Hard";
        }

        public Person(string name)
        {
            // 使用this关键字来引用字段name,以和参数name区分开来
            // this 代表当前类的实例对象
            Console.WriteLine("实例构造函数被调用了");
            this.name = name;
        }
    }

    class Program
    {
        // 演示带参数构造函数的使用
        //static void Main(string[] args)
        //{
        //    // 调用无参数构造函数来实例化Person类，即创建类对象
        //    Person personWithoutPara = new Person();

        //    // 调用带参数的构造函数，此时需要传入一个字符串作为参数，这里传入“张三”
        //    Person personWithPara = new Person("张三");

        //    // 分别输出两个对象的Name属性
        //    Console.WriteLine(personWithoutPara.Name);
        //    Console.WriteLine(personWithPara.Name);
        //    Console.Read();
        //}
    }
}
