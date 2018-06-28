using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._7
{
    
    class Program
    {
        // 定义闭包委托
        delegate void ClosureDelegate();

        static void Main(string[] args)
        {
            // 调用方法
            closureMethod();
            Console.Read();
        }

        // 闭包方法
        private static void closureMethod()
        {
            // outVariable和capturedVariable对于匿名方法而言都是外部变量
            string outVariable = "外部变量";

            //  而capturedVariable是被匿名方法捕获的外部变量
            string capturedVariable = "被捕获的外部变量";
            ClosureDelegate closuredelegate = delegate
            {
                // localvariable是匿名方法中局部变量
                string localvariable = "匿名方法局部变量";

                // 引用capturedVariable变量
                Console.WriteLine(capturedVariable + " " + localvariable);
            };

            // 调用委托
            closuredelegate();
        }
    }
}
