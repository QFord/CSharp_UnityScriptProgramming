using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._5
{
    class Program
    {
        // 定义投票委托
        delegate void VoteDelegate(string name);
        static void Main(string[] args)
        {
            // 使用Vote方法来实例化委托对象
            //VoteDelegate votedelegate = new VoteDelegate(new Friend().Vote);
            // 下面方式为隐式实例化委托对象方式，把方法直接赋给委托对象
            VoteDelegate votedelegate = new Friend().Vote;

            // 通过调用托来回调Vote()方法，此为隐式调用方式
            votedelegate("SomeBody");
            Console.Read();
        }

        public class Friend
        {
            // 朋友的投票方法
            public void Vote(string nickname)
            {
                Console.WriteLine("昵称为：{0} 来帮Learning Hard投票了", nickname);
            }
        }
    }
}
