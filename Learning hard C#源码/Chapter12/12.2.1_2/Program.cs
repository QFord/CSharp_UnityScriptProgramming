using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._6
{
    // 匿名方法的使用演示
    class Program
    {   
        // 定义投票委托
        delegate void VoteDelegate(string name);
        static void Main(string[] args)
        {
            // 使用匿名方法来实例化委托对象
            VoteDelegate votedelegate = delegate(string nickname)
            {
                Console.WriteLine("昵称为：{0} 来帮Learning Hard投票了", nickname);
            };

            // 通过调用托来回调Vote()方法，此为隐式调用方式
            votedelegate("SomeBody");
            Console.Read();
        }
    }
}
