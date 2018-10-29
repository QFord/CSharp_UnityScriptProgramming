using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._8
{
    // 闭包演示
    class Program
    {
        // 定义闭包委托
        delegate void ClosureDelegate();

        static void Main(string[] args)
        {
            ClosureDelegate test = CreateDelegateInstance();
            // 此时会回调匿名方法输出count的值
            test();

            /*
             1
             2
             */

            Console.Read();
        }

        // 闭包延长变量的生命周期
        private static ClosureDelegate CreateDelegateInstance()
        {
            // 外部变量
            int count = 1;
            ClosureDelegate closuredelegate = delegate
            {           
                Console.WriteLine(count);
                // 捕捉了外部变量
                count++;
            };
            // 调用委托
            closuredelegate();
            return closuredelegate;
        }
    }
}
