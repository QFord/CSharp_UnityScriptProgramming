using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceImplicitImp
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
        // 隐式接口实现
        public void SayHello()
        {
            Console.WriteLine("你好");
        }
    }

    public abstract class Test
    {
        public virtual void Say()
        {
            Console.WriteLine("a");
        }
        public void A()
        { 
        }
    }
}
