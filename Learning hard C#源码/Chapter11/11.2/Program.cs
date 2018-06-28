using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace _11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 泛型数组
            //List<int> genericlist = new List<int>();
            //genericlist.Add("abc");
            // 测试泛型类型运行时间
            testGeneric();
            // 测试非泛型类型运行时间
            testNonGeneric();
            // 调用泛型方法
            //Console.WriteLine(Compare<int>.compareGeneric(3, 4));
            //Console.WriteLine(Compare<string>.compareGeneric("abc", "a"));
            Console.Read();
        }

        // 测试泛型类型操作时运行时间
        public static void testGeneric()
        {
            // Stopwatch对象用来测量运行时间
            Stopwatch stopwatch = new Stopwatch();

            // 泛型数组
            List<int> genericlist = new List<int>();
            // 开始计时
            stopwatch.Start();
            // 循环1千万次来比较运行时间
            for (int i = 1; i < 10000000; i++)
            {
                // 泛型测试
                genericlist.Add(i);
            }
            // 出现编译错误
            //genericlist.Add("learing");
            // 结束计时
            stopwatch.Stop();

            // 输出所用的时间
            TimeSpan ts = stopwatch.Elapsed;
            // 使时间以 00:00:00这样的个数输出
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
             ts.Hours, ts.Minutes, ts.Seconds,
             ts.Milliseconds / 10);
            Console.WriteLine("泛型类型运行的时间： " + elapsedTime);
        }

        // 测试非泛型类型操作时运行时间
        public static void testNonGeneric()
        {
            // Stopwatch对象用来测量运行时间
            Stopwatch stopwatch = new Stopwatch();

            // 非泛型数组，需要额外添加System.Collections命名空间
            ArrayList arraylist = new ArrayList();

            // 开始计时
            stopwatch.Start();
            // 循环1千万次来比较运行时间
            for (int i = 1; i < 10000000; i++)
            {
                // 非泛型测试
                arraylist.Add(i);
            }

            // 结束计时
            stopwatch.Stop();

            // 输出所用的时间
            TimeSpan ts = stopwatch.Elapsed;
            // 使时间以 00:00:00这样的个数输出
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
             ts.Hours, ts.Minutes, ts.Seconds,
             ts.Milliseconds / 10);
            Console.WriteLine("非泛型类型运行的时间： " + elapsedTime);
        }
    }

    public class Compare
    {
        // 比较两个int整数大小的方法,方法返回较大的那个整数
        public static int compareInt(int int1, int int2)
        {
            if (int1.CompareTo(int2) > 0)
            {
                return int1;
            }
            else
            {
                return int2;
            }
        }

        // 比较两个字符串大小，返回较大的字符串
        public static string compareString(string str1, string str2)
        {
            if (str1.CompareTo(str2) > 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }

    // Compare<T>为泛型类，T为类型参数
    public class Compare<T> where T : IComparable
    {
        // 使用泛型实现的比较方法
        public static T compareGeneric(T t1, T t2)
        {
            if (t1.CompareTo(t2) > 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }
    }
}
