using System;
using System.Threading;

namespace _19._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread backThread = new Thread(Worker);
            backThread.IsBackground = true;
            backThread.Start();
            backThread.Join();
            Console.WriteLine("从主线程中退出");
        }
        public static void Worker()
        {
            Thread.Sleep(1000);
            Console.WriteLine("从后台线程退出");
        }
    }
}
