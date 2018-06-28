using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventArgsExt
{
    // 自定义事件类，使其带有事件数据
    public class MarryEventArgs : EventArgs
    {
        public string Message;
        public MarryEventArgs(string msg)
        {
            Message = msg;
        }
    }

    // 新郎官类，充当事件发布者角色
    public class Bridegroom
    {
        // 自定义委托类型，委托具有两个参数
        public delegate void MarryHandler(object sender, MarryEventArgs e);

        // 定义事件
        public event MarryHandler MarryEvent;

        // 发出事件
        public void OnBirthdayComing(string msg)
        {
            // 判断是否绑定了事件处理方法
            if (MarryEvent != null)
            {
                // 触发事件
                MarryEvent(this, new MarryEventArgs(msg));
            }
        }

        static void Main(string[] args)
        {
            //初始化新郎官对象
            Bridegroom bridegroom = new Bridegroom();

            // 实例化朋友对象
            Friend friend1 = new Friend("张三");
            Friend friend2 = new Friend("李四");
            Friend friend3 = new Friend("王五");

            // 使用+=订阅事件
            bridegroom.MarryEvent += new MarryHandler(friend1.SendMessage);
            bridegroom.MarryEvent += new MarryHandler(friend2.SendMessage);

            // 发出通知,此时订阅了事件的对象才能收到通知
            bridegroom.OnBirthdayComing("朋友们，我结婚了，到时候准时参加婚礼!");
            Console.WriteLine("------------------------------------");

            // 使用-=取消订阅事件,此时李四将收不到通知
            bridegroom.MarryEvent -= new MarryHandler(friend2.SendMessage);

            // 使用+=订阅事件，此时王五可以收到通知
            bridegroom.MarryEvent += new MarryHandler(friend3.SendMessage);

            // 发出通知
            bridegroom.OnBirthdayComing("朋友们，我结婚了，到时候准时参加婚礼!");
            Console.Read();
        }
    }

    // 朋友类
    public class Friend
    {
        // 字段
        public string Name;

        // 构造函数
        public Friend(string name)
        {
            Name = name;
        }

        // 事件处理函数，该函数需要符合MarryHandler委托的定义
        public void SendMessage(object s, MarryEventArgs e)
        {
            // 输出通知信息
            Console.WriteLine(e.Message);

            // 对事件做出处理
            Console.WriteLine(this.Name + "收到了，到时候准时参加");
        }
    }
}
