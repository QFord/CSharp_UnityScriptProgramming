using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // 密封类的定义
    // 使用sealed关键字来定义密封类
    public sealed class SealedClass
    {
        // 在这里定义类成员
    }

    // 密封类不能作为其他类的基类，正因为这点它也不能为抽象类
    // 下面代码编译时会出错
    //public class Test : SealedClass
    //{ 
    //}
}
