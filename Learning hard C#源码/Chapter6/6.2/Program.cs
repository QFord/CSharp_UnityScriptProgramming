using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseInterface
{
    // 接口中方法的调用
    class Program
    {
        static void Main(string[] args)
        {
           // 创建两个Person对象
            Person p1 = new Person();
            p1.Age = 18;
            Person p2 = new Person();
            p2.Age = 19;
            // 调用接口中方法把p1与p2比较
            ICustomCompare iCustomCompare = (ICustomCompare)p1;
            if (iCustomCompare.CompareTo(p2) > 0)
            {
                Console.WriteLine("p1比p2大");
            }
            else if (iCustomCompare.CompareTo(p2) < 0)
            {
                Console.WriteLine("p1比p2小");
            }
            else
            {
                Console.WriteLine("p1和p2一样大");
            }
            Console.Read();
        }
    }
}

