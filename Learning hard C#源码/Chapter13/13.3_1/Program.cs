using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用对象初始化器初始化
            Person p = new Person() { Name = "LearningHard", Age = 25, Weight = 60, Height = 170 };
            // 下面代码和上面代码是等价的，只不过下面省略了构造函数的圆括号而已
            Person p2 = new Person { Name = "LearningHard", Age = 25, Weight = 60, Height = 170 };
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
    }

    //public class Person
    //{
    //    // 名字
    //    public string Name{get;set;}

    //    // 年龄
    //    public int Age{get;set;}

    //    // 体重
    //    public int Weight{get;set;}
    //    // 身高
    //    public int Height {get;set;}

    //    // 定义不同情况下的初始化
    //    public Person():this("")
    //    {
    //    }
    //    public Person(string name):this(name,0)
    //    {
    //    }
    //    public Person(string name,int age):this(name,age,0)
    //    {
    //    }
    //    public Person(string name, int age, int weight):this(name,age,weight,0)
    //    {
    //    }
    //    public Person(string name, int age, int weight, int height)
    //    {
    //        this.Name=name;
    //        this.Age=age;
    //        this.Weight=weight;
    //        this.Height=height;
    //    }
    //}
}
