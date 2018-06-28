using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 编译器推断为int[]类型
            var intarray = new[] { 1, 2, 3, 4 };

            // 编译器推断为string[] 类型
            var stringarray = new[] { "hello", "learning hard" };

            // 隐式类型数组出错的情况
            //var errorarray = new[] { "hello", 3 };
        }
    }
}
