using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._3_2
{
    // 泛型类，具有一个类型参数
    public static class TypeWithStaticField<T>
    {
        // 静态字段
        public static string field;
        // 静态构造函数
        public static void OutField()
        {
            Console.WriteLine(field + ":" + typeof(T).Name);
        }
    }

    // 非泛型类
    public static class NoGenericTypeWithStaticField
    {
        public static string field;
        public static void OutField()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 使用不同的类型实参来实例化泛型实例
            TypeWithStaticField<int>.field = "一";
            TypeWithStaticField<string>.field = "二";
            TypeWithStaticField<Guid>.field = "三";

            // 对于非泛型类型，此时filed 值只会有一个值，每个赋值都是改变了原来的值
            NoGenericTypeWithStaticField.field = "非泛型类静态字段一";
            NoGenericTypeWithStaticField.field = "非泛型类静态字段二";
            NoGenericTypeWithStaticField.field = "非泛型类静态字段三";

            NoGenericTypeWithStaticField.OutField();

            // 证明每个封闭类型都有一个静态字段
            TypeWithStaticField<int>.OutField();
            TypeWithStaticField<string>.OutField();
            TypeWithStaticField<Guid>.OutField();
            Console.Read();
        }
    }
}
