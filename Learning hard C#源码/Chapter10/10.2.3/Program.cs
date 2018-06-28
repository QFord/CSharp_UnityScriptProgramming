using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamPass
{
    // 类定义
    public class RefClass
    {
        public int addNum;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3. String引用类型的按值传递的特殊情况
            Console.WriteLine(" String引用类型按值传递的特殊情况");
            string str = "old string";
            ChangeStr(str);
            Console.WriteLine("调用方法后，实参str的值:"+str);

            Console.Read();
        }

        // 3. String引用类型的按值传递的特殊情况
        private static void ChangeStr(string oldStr)
        {
            oldStr = "New string";
            Console.WriteLine("方法中oldStr的值:"+oldStr);
        }
    }
}
