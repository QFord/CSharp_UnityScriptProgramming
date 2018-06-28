using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化泛型实例
            List<object> listobject = new List<object>();
            List<string> liststrs = new List<string>();

            // 初始化TestComparer实例
            IComparer<object> objComparer = new TestComparer();
            IComparer<string> stringComparer = new TestComparer();
            
            liststrs.Sort(objComparer);  // 正确

            // 出错
            //listobject.Sort(stringComparer);
        }
    }

    // 自定义类实现IComparer<object>接口
    public class TestComparer : IComparer<object>
    {
        public int Compare(object obj1, object obj2)
        {
            return obj1.ToString().CompareTo(obj2.ToString());
        }
    }
}
