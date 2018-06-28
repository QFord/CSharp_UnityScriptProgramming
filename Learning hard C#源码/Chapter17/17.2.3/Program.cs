using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 下面初始化委托使用了Lambda表达式，Lambda表达式将在后面专题向大家具体介绍
            Func<string> stringfunc = () => "";
            Func<object> objectfunc = () => new object();
            Func<object> combined = stringfunc + objectfunc;
        }
    }
}
