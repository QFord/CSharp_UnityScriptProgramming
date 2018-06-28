using System;
using System.Windows.Forms;

namespace _14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新建一个button实例
            Button button1 = new Button();
            button1.Text = "点击我";

            // C# 2中使用匿名方法来订阅事件
            button1.Click += delegate(object sender, EventArgs e)
            {
                ReportEvent("Click事件", sender, e);
            };
            button1.KeyPress += delegate(object sender, KeyPressEventArgs e)
            {
                ReportEvent("KeyPress事件，即键盘按下事件", sender, e);
            };

            // C# 3之前初始化对象时使用下面代码
            Form form = new Form();
            form.Name = "在控制台中创建的窗体";
            form.AutoSize = true;
            form.Controls.Add(button1);
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

           
        }
    }
}
