using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceImplicitImp
{
    class Program
    {
        // 隐式接口实现存在的问题
        static void Main(string[] args)
        {
            // 初始化类实例
            Speaker speaker = new Speaker();

            // 调用中国人打招呼方法
            IChineseGreeting iChineseG = (IChineseGreeting)speaker;
            iChineseG.SayHello();

            // 调用美国人招呼方法
            IAmericanGreeting iAmericanG = (IAmericanGreeting)speaker;
            iAmericanG.SayHello();

            Console.Read();
        }
    }
}
