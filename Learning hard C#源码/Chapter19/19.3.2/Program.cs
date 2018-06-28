using System;
using System.Threading;
namespace _19._6
{
    class Program
    {
        static int tickets = 100;
        static object gloalObj = new object(); // 辅助对象
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(SaleTicketThread1);
            Thread thread2 = new Thread(SaleTicketThread2);
            thread1.Start();
            thread2.Start();        
        }
        private static void SaleTicketThread1()
        {
            while (true)
            {
                Monitor.Enter(gloalObj); // 在object对象上获得排他锁
                Thread.Sleep(1);
                if (tickets > 0)
                    Console.WriteLine("线程一出票：" + tickets--);
                else
                    break;

                Monitor.Exit(gloalObj); // 释放指定对象上的排他锁
            }
        }
        private static void SaleTicketThread2()
        {
            while (true)
            {
                Monitor.Enter(gloalObj);
                Thread.Sleep(1);
                if (tickets > 0)
                    Console.WriteLine("线程2出票：" + tickets--);
                else
                    break;

                Monitor.Exit(gloalObj);
            }
        }
    }
}
