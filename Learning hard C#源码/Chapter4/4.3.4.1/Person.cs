using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstanceConstructors
{

    // 只定义了私有构造函数的类
    // 下面实现也是设计模式中单例模式的实现，关于设计模式的内容请参考相关资料或书籍
    class Person
    {

        // 私有字段
        private string name;
        // 公共静态字段
        public static Person person;

        // 只读属性
        public string Name
        {
            get { return this.name; }
        }

        // 私有构造函数，只能在类内部调用
        // 也就是说类的实例化只能在类的定义被实例化
        private Person()
        {
            Console.WriteLine("私有构造函数被调用");
            this.name = "Learning Hard";
        }

        // 静态方法，用于返回类的实例
        public static Person GetInstance()
        {
            person = new Person();
            return person;
        }
    }

    class Program
    {
        // 演示私有构造函数的调用
        static void Main(string[] args)
        {
            // 通过调用GetInstance()静态方法来返回一个Person的实例
            // 此时不能使用new运算符来创建实例，
            // 即不能使用 代码来创建实例
            //Person person =new Person();
            Person person = Person.GetInstance();
            // 输出类的Name属性
            Console.WriteLine("类实例的Name属性为：{0}", person.Name);
            Console.Read();
        }
    }
    public class Test
    {
        //嵌套类 Nested class
        private class test1
        {

        }
    }

}

