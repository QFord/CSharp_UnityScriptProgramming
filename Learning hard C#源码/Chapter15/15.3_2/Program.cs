using System;

namespace CurrentNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Learning hard" };
            // 由于同一命名空间下存在两个Print扩展方法，此时编译器不能判断调用哪个，则出现编译错误
            //p.Print();
            Console.Read();
        }
    }

    // 自定义类型
    public class Person
    {
        public string Name { get; set; }
    }

    // 当前命名空间下的扩展方法定义
    public static class Extensionclass1
    {
        /// <summary>
        ///  扩展方法定义
        /// </summary>
        /// <param name="per"></param>
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是当前命名空间下的扩展方法输出，姓名为: {0}", per.Name);
        }
    }

    // 当前命名空间下的扩展方法定义
    public static class Extensionclass2
    {
        
        // 同一命名空间下定义了两个相同的扩展方法Print
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是当前命名空间下的扩展方法输出，姓名为: {0}", per.Name);
        }
    }
}
