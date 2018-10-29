using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;
            // 不使用类型推断的代码
            //genericMethod<int>(ref n1, ref n2);
            genericMethod(ref n1, ref n2);
            Console.WriteLine("n1的值现在为：" + n1);
            Console.WriteLine("n2的值现在为：" + n2);

            string str1 = "123";
            object obj = "456";
            // 使用类型推断出现编译错误
            //genericMethod(ref str1, ref obj);
            Console.Read();

            System.ValueType
        }

        // 泛型方法
        private static void genericMethod<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }

    public class Test<T>
    {
 
    }
}
