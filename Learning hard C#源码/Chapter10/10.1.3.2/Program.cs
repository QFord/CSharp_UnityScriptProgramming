using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxAndUnBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            // 装箱操作
            object o = i;
            // 拆箱操作
            int y = (int)o;
        }
    }
}
