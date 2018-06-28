using System;

namespace CurrentNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("空引用上调用扩展方法演示：");

            // s为空引用
            string s = null;

            // 在空引用上调用扩展方法不会发生NullReferenceException异常
            Console.WriteLine("字符串S为空字符串：{0}", s.IsNull());
            Console.Read();
        }
    }

    public static class NullExten
    {
        // 不规范定义扩展方法的方式
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
