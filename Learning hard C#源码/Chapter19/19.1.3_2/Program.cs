using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _19._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread parmThread = new Thread(new ParameterizedThreadStart(Worker));
            parmThread.Name = "线程1";
            parmThread.Start("123");
            Console.WriteLine("从主线程返回");
        }
        private static void Worker(object data)
        {
            Thread.Sleep(1000);
            Console.WriteLine("传入的参数为:" + data.ToString());
            Console.WriteLine("从线程1返回");
            Console.Read();
        }
    }
}
