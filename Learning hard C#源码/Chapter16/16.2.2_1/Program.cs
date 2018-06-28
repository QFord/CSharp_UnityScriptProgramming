using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16._1
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

            Console.WriteLine("使用老方法来对集合对象查询，查询结果为：");
            OldQuery(inputArray);
            Console.Read();
        }

        // 使用foreach返回集合中为偶数的元素
        private static void OldQuery(List<int> collection)
        {
            // 创建保存查询结果的集合
            List<int> queryResults = new List<int>();
            foreach (int item in collection)
            {
                // 判断元素是偶数情况
                if (item % 2 == 0)
                {
                    queryResults.Add(item);
                }
            }

            // 输出查询结果
            foreach (int item in queryResults)
            {
                Console.Write(item+"  ");
            }
        }
    }
}
