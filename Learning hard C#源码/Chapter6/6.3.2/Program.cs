using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExplicitImp
{
    class Program
    {
        // 显式接口实现演示
    static void Main(string[] args)
    {
        // 初始化类实例
        Speaker speaker = new Speaker();

        // 调用中国人打招呼方法
        // 显式转化为IChineseGreeting接口来调用SayHello方法。
        IChineseGreeting iChineseG = (IChineseGreeting)speaker;
        iChineseG.SayHello();

        // 调用美国人打招呼方法
        // 显式转化为IAmericanGreeting接口来调用SayHello方法。
        IAmericanGreeting iAmericanG = (IAmericanGreeting)speaker;
        iAmericanG.SayHello();
        Console.Read();
    }
    }
}
