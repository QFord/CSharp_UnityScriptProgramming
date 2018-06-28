using System;
using System.Diagnostics;
using System.Threading;
namespace _19._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            const int iterationNumber = 5000000;  // 迭代次数为500万 
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < iterationNumber; i++)
            {
                x++;
            }
            Console.WriteLine("不使用锁的情况下花费的时间 :{0} ms", sw.ElapsedMilliseconds);
            sw.Restart();

            for (int i = 0; i < iterationNumber; i++)  // 使用锁的情况
            {
                Interlocked.Increment(ref x);
            }

            Console.WriteLine("使用锁的情况下花费的时间 :{0} ms", sw.ElapsedMilliseconds);
            Console.Read();
        }
    }
}
