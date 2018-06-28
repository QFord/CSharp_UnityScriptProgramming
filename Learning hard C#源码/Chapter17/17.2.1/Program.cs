using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化泛型实例
            List<object> listobject = new List<object>();
            List<string> liststrs = new List<string>();

            listobject.AddRange(liststrs);  //成功
            //liststrs.AddRange(listobject); // 出错
        }
    }
}
