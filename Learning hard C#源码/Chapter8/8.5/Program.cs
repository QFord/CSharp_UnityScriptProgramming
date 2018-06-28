using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MulticastDelegates
{
    class Program
    {
        // 声明一个委托类型
        public delegate void DelegateTest();
        static void Main(string[] args)
        {
            // 用静态方法来实例化委托
            DelegateTest dtstatic = new DelegateTest(Program.method1);

            DelegateTest dtinstance= new DelegateTest(new Program().method2);
            
            // 定义一个委托对象，一开始初始化为null，就是不代表任何方法（我就是我，我不代表任何人）
            DelegateTest delegatechain = null;

            // 使用+符号链接委托，链接多个委托后就成为委托链了
            delegatechain += dtstatic;
            delegatechain += dtinstance;
            Console.WriteLine("delegatechain's number methods : "+ delegatechain.GetInvocationList().Length);
            // 使用-运算符把dtstatic委托从委托链中移除
            delegatechain -= dtstatic;

            // 调用委托链
            delegatechain.Invoke();
            Console.Read();
        }

        // 静态方法
        private static void method1()
        {
            Console.WriteLine( "这是静态方法");
        }

        // 实例方法
        private void method2()
        {
            Console.WriteLine( "这是实例方法");
        }

        
    }
}
