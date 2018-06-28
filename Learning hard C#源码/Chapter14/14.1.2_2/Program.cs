using System;
using System.Windows.Forms;

namespace _14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新建一个button实例
            Button button1 = new Button() { Text = "点击我" };

            // C# 3Lambda表达式方式来订阅事件
            button1.Click += (sender, e) => ReportEvent("Click事件", sender, e);
            button1.KeyPress += (sender, e) => ReportEvent("KeyPress事件，即键盘按下事件", sender, e);

            // C# 3中使用对象初始化器
            Form form = new Form { Name = "在控制台中创建的窗体", AutoSize = true, Controls = { button1 } };

            // 运行窗体
            Application.Run(form);
        }
        // 记录事件的回调方法
        private static void ReportEvent(string title, object sender, EventArgs e)
        {
            Console.WriteLine("发生的事件为：{0}", title);
            Console.WriteLine("发生事件的对象为：{0}", sender);
            Console.WriteLine("发生事件参数为： {0}", e.GetType());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
