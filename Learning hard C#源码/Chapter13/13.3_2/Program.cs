using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用对象初始化器初始化
            Person p = new Person() { Name = "LearningHard", Age = 25, Weight = 60, Height = 170 };
        }
    }
    public class Person
    {
        // 名字
        public string Name { get; set; }

        // 年龄
        public int Age { get; set; }

        // 体重
        public int Weight { get; set; }
        // 身高
        public int Height { get; set; }

        //自定义有参构造函数把默认无参构造函数覆盖了
        public Person(string name)
        {
            this.Name = name;
        }
        //下面这个忽略就会造成错误，从反编译代码中可以看到需要无参构造函数
        public Person()
        {
        }
    }
    
}
