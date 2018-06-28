using System;
using System.Threading;

namespace _19._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程ID = {0}", Thread.CurrentThread.ManagedThreadId);
            ThreadPool.QueueUserWorkItem(CallBackWorkItem);
            ThreadPool.QueueUserWorkItem(CallBackWorkItem, "work");
            Thread.Sleep(3000);
            Console.WriteLine("主线程退出");
            
        }
        private static void CallBackWorkItem(object state)
        {       
            Console.WriteLine("线程池线程开始执行");
            if(state != null)
            {
                Console.WriteLine("线程池线程ID = {0} 传入的参数为 {1}", Thread.CurrentThread.ManagedThreadId, state.ToString());
            }
            else
            {
                Console.WriteLine("线程池线程ID = {0}", Thread.CurrentThread.ManagedThreadId);
            }   
        }
    }
}
