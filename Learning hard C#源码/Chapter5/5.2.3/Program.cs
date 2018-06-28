using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Initializationorder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化子类实例
            ChildA child = new ChildA();
            child.Print();
            Console.Read();
        }
    }

    public class Parent
    {
        // ②调用基类构造函数
        public Parent()
        {
            Console.WriteLine("基类构造函数被调用"+System.DateTime.Now.Millisecond);
        }
    }

    public class ChildA : Parent
    {
        // 创建一个ChildA对象时，首先初始化它的实例字段
        // ①
        private int FieldA = 3;

        // ③调用子类构造函数
        public ChildA()
        {
            Console.WriteLine("子类构造函数被调用"+System.DateTime.Now.Millisecond);
        }

        public void Print()
        {
            Console.WriteLine(FieldA+System.DateTime.Now.Millisecond.ToString());
        }
    }
}
