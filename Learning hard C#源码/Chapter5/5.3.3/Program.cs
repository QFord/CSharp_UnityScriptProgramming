using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用Horse中Eat方法
            Horse horse = new Horse();
            horse.Eat();

            // 调用基类的Eat方法
            ((Animal)horse).Eat();
            Console.Read();
        }
    }

    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("动物吃方法");
        }
    }

    public class Horse : Animal
    {
        // 使用new关键字修饰来隐藏基类同名成员
        public new void Eat()
        {
            Console.WriteLine("马吃的方法");
        }
    }
}
