using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化查询的数据
            List<int> inputArray = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                inputArray.Add(i);
            }
            Console.WriteLine("使用Linq方法来对集合对象查询，查询结果为：");
            LinqQuery(inputArray);
        }

        // 使用Linq返回集合中为偶数的元素
        private static void LinqQuery(List<int> collection)
        {
            // 创建查询表达式来获得集合中为偶数的元素
            var queryResults = from item in collection
                               where item % 2 == 0
                               select item;
            // 输出查询结果
            foreach (var item in queryResults)
            {
                Console.Write(item+"  ");
            }
        }
    }
}
