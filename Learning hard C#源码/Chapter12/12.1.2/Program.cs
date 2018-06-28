using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("??运算符的使用如下：");
            NullcoalescingOperator();
            Console.Read();
        }
        // ??运算符的演示
        private static void NullcoalescingOperator()
        {
            int? nullable = null;
            int? nullhasvalue = 1;

            // ??和三目运算符的功能差不多的
            // 所以下面代码等价于：
            // x=nullable.HasValue?b.Value:12;
            int x = nullable ?? 12;

            // 此时nullhasvalue不能null,所以y的值为nullhasvalue.Value,即输出1
            int y = nullhasvalue ?? 123;
            Console.WriteLine("可空类型没有值的情况：{0}", x);
            Console.WriteLine("可空类型有值的情况：{0}", y);

            // 同时??运算符也可以用于引用类型， 下面是引用类型的例子
            Console.WriteLine();
            string stringnotnull = "123";
            string stringisnull = null;

            // 下面的代码等价于：
            // (stringnotnull ==null)? "456" :stringnotnull
            // 也也等价于：
            // if(stringnotnull==null)
            // {
            //      return "456";
            // }
            // else
            // {
            //      return stringnotnull;
            // }

            // 从上面的等价代码可以看出，有了??运算符之后可以省略大量的if—else语句，这样代码少了， 自然可读性就高了
            string result = stringnotnull ?? "456";
            string result2 = stringisnull ?? "12";
            Console.WriteLine("引用类型不为null的情况：{0}", result);
            Console.WriteLine("引用类型为null的情况：{0}", result2);
        }
    }
}
