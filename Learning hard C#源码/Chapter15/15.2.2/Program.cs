using System;
using System.Collections.Generic;

namespace _15._2
{
    public static class ListExten
    {
        // 定义扩展方法
        public static int JSum(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("输入数组为空");
            }

            int jsum = 0;

            // flag变量用来计算下标为奇数的所有项之和
            bool flag = false;
            foreach (int current in source)
            {
                if (flag = !flag)
                {
                    jsum += current;
                    //flag = true;
                }
                //else
                //{
                //    flag = false;
                //}
            }

            return jsum;
        }
    }

    class Program
    {
        // 调用扩展方法演示
        static void Main(string[] args)
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5, 6, 3 };
            // 扩展方法的另一种调用方式
            int jSum = source.JSum();
            Console.WriteLine("数组的奇数和为：" + jSum);
            Console.Read();
        }
    }
}
