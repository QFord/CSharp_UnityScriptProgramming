using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 下面代码也可以这样子定义int? value=1;
            Nullable<int> value = 1;

            Console.WriteLine("可空类型有值的输出情况：");
            Display(value);
            Console.WriteLine();
            Console.WriteLine();

            value = new Nullable<int>();
            Console.WriteLine("可空类型没有值的输出情况：");
            Display(value);
            Console.Read();
        }

        // 输出方法，演示可空类型中的方法和属性的使用
        private static void Display(int? nullable)
        {
            // HasValue 属性代表指示可空对象是否有值
            Console.WriteLine("可空类型是否有值：{0}", nullable.HasValue);
            if (nullable.HasValue)
            {
                Console.WriteLine("值为: {0}", nullable.Value);
            }

            // GetValueOrDefault(代表如果可空对象有值,就用它的值返回,如果可空对象不包含值时,使用默认值0返回)相当与下面的语句
            // if (!nullable.HasValue)
            // {
            //    result = d.Value;
            // }

            Console.WriteLine("GetValueorDefault():{0}", nullable.GetValueOrDefault());

            // GetValueOrDefault(T)方法代表如果 HasValue 属性为 true，则为 Value 属性的值；否则为 defaultValue 参数值,即2。
            Console.WriteLine("GetValueorDefalut重载方法使用：{0}", nullable.GetValueOrDefault(2));

            // GetHashCode()代表如果 HasValue 属性为 true，则为 Value 属性返回的对象的哈希代码；如果 HasValue 属性为 false，则为零
            Console.WriteLine("GetHashCode()方法的使用：{0}", nullable.GetHashCode());
        }
    }
}
