
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._3__3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 每个封闭泛型类型都会调用其构造函数
            GenericClass<int>.Print();
            GenericClass<string>.Print();

            // 对于非泛型类型，其构造函数只会调用一次
            NonGenericClass.Print();
            NonGenericClass.Print();
            Console.Read();
        }
    }

    // 泛型类
    public static class GenericClass<T>
    {
        // 静态构造函数
        static GenericClass()
        {
            Console.WriteLine("泛型的静态构造函数被调用了,实际类型为："+typeof(T));
        }

        // 静态方法
        public static void Print()
        {
        }
    }
    // 非泛型类
    public static class NonGenericClass
    {
        static NonGenericClass()
        {
            Console.WriteLine("非泛型的静态构造函数被调用了");
        }

        public static void Print()
        {
        }
    }
}
