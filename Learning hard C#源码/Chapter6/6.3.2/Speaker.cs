using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExplicitImp
{
    // 中国人打招呼接口
    interface IChineseGreeting
    {
        // 接口方法声明
        void SayHello();
    }

    // 美国人打招呼接口
    interface IAmericanGreeting
    {
        // 接口方法声明
        void SayHello();
    }

    // Speaker类实现了两个接口
    public class Speaker : IChineseGreeting, IAmericanGreeting
    {
        // 错误！不能有访问修饰符修饰，因为默认为私有的
        void IChineseGreeting.SayHello()
        {
            Console.WriteLine("你好");
        }

        void IAmericanGreeting.SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
