using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefParamPass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型参数的按引用传递情况");
            // num是值类型实参
            int num = 1;
            // refStr是引用类型实参
            string refStr = "Old string";
            // 值类型参数的按引用传递
            ChangeByValue(ref num);
            Console.WriteLine(num);

            // 引用类型参数的按引用传递
            changeByRef(ref refStr);
            Console.WriteLine(refStr);

            Console.Read();
        }

        // 1. 值类型参数的按引用传递情况
        private static void ChangeByValue(ref int numValue)
        {
            numValue = 10;
            Console.WriteLine(numValue);
        }

        // 2. 引用类型参数的按引用传递情况
        private static void changeByRef(ref string numRef)
        {
            numRef = "new string";
            Console.WriteLine(numRef);
        }
    }
}
