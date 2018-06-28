using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("可空类型的装箱和拆箱的使用如下：");
            BoxedandUnboxed();
            Console.Read();
        }

        // 可空类型装箱和拆箱的演示
        private static void BoxedandUnboxed()
        {
            // 定义一个可空类型对象nullable
            Nullable<int> nullable = 5;
            int? nullablewithoutvalue = null;
           
            Console.Write(nullablewithoutvalue.Value);
            // 获得可空对象的类型，此时返回的是System.Int32,而不是System.Nullable<System.Int32>,这点大家要特别注意下的
            Console.WriteLine("获取不为null的可空类型的类型为：{0}", nullable.GetType());

            // 对于一个为null的类型调用方法时出现异常，所以一般对于引用类型的调用方法前，最好养成习惯先检测下它是否为null
            //Console.WriteLine("获取为null的可空类型的类型为：{0}", nullablewithoutvalue.GetType());

            // 将可空类型对象赋给引用类型obj,此时会发生装箱操作，大家可以通过IL中的boxed 来证明
            object obj = nullable;

            // 获得装箱后引用类型的类型，此时输出的仍然是System.Int32,而不是System.Nullable<System.Int32>
            Console.WriteLine("获得装箱后obj 的类型：{0}", obj.GetType());

            // 拆箱成非可空变量
            int value = (int)obj;
            Console.WriteLine("拆箱成非可空变量的情况为：{0}", value);

            // 拆箱成可空变量
            nullable = (int?)obj;
            Console.WriteLine("拆箱成可空变量的情况为：{0}", nullable);

            // 装箱一个没有值的可空类型的对象
            obj = nullablewithoutvalue;
            Console.WriteLine("对null的可空类型装箱后obj 是否为null：{0}", obj == null);

            // 拆箱成非可空变量,此时会抛出NullReferenceException异常,因为没有值的可空类型装箱后obj等于null,引用一个空地址
            // 相当于拆箱后把null值赋给一个int 类型的变量,此时当然就会出现错误了
            //value = (int)obj;
            //Console.WriteLine("一个没有值的可空类型装箱后，拆箱成非可空变量的情况为：{0}", value);

            // 拆箱成可空变量
            nullable = (int?)obj;
            Console.WriteLine("一个没有值的可空类型装箱后，拆箱成可空变量是否为null：{0}", nullable == null);
        }
    }
}
