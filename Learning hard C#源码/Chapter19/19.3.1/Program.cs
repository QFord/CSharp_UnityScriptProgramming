using System;
using System.Threading;

namespace _19._5
{
    class Program
    {
        static int tickets = 100;
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(SaleTicketThread1);
            Thread thread2 = new Thread(SaleTicketThread2);
            thread1.Start();
            thread2.Start();
            Thread.Sleep(4000);
        }
        private static void SaleTicketThread1()
        {
            while (true)
            {
                if (tickets > 0)
                    Console.WriteLine("线程一出票：" +tickets--);
                else
                    break;
            }
        }
        private static void SaleTicketThread2()
        {
            while (true)
            {
                if (tickets > 0)
                    Console.WriteLine("线程2出票：" +tickets--);
                else
                    break;
            }
        }
    }
}
