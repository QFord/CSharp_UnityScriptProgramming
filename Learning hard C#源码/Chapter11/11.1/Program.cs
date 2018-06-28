using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用int作为实际参数来初始化泛型类型
            List<int> intList = new List<int>();
            // 从int列表添加元素3
            intList.Add(3);

            // 用string作为实际参数来初始化泛型类型
            List<string> stringList = new List<string>();
            // 从string列表添加元素
            stringList.Add("learninghard");
        }
    }
}
