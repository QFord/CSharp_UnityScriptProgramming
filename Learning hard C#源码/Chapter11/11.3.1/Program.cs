using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._3_1
{
    // 声明开放泛型类型
    public class DictionaryStringKey<T> : Dictionary<string, T>
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  Dictionary<,>是一个开放类型，它有2个类型参数
            Type t = typeof(Dictionary<,>);
            Console.WriteLine("是否为开放类型: "+t.ContainsGenericParameters);
            // DictionaryStringKey<>也是一个开放类型，但它有1个类型参数
            t = typeof(DictionaryStringKey<>);
            Console.WriteLine("是否为开放类型: " + t.ContainsGenericParameters);
            // DictionaryStringKey<int>是一个封闭类型
            t = typeof(DictionaryStringKey<int>);
            Console.WriteLine("是否为开放类型: " + t.ContainsGenericParameters);
            // Dictionary<int, int>是封闭类型
            t = typeof(Dictionary<int, int>);
            Console.WriteLine("是否为开放类型: " + t.ContainsGenericParameters);
            Console.Read();
        }   
    }
}
