using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SnippingTool
{
    /// <summary>
    ///  有些人会问,为什么把Alt定义为1， Ctrl为2了
    ///  因为 http://msdn.microsoft.com/en-us/library/windows/desktop/ms646309(v=vs.85).aspx 列出了值的对应关系
    /// 定义辅助键的名称,也就是定义RegisterHotKey第三个参数的取值
    /// （将数字转化为字符，可以使大家更容易理解代码）
    /// </summary>
    [Flags]
    public enum KeyModifiers
    {
        None = 0,
        Alt = 1,
        Ctrl = 2,
        Shift = 4,
        WindowsKey = 8
    }

    public partial class 聊天窗体 : Form
    {
        public 聊天窗体()
        {
            InitializeComponent();
        }

        Cutter cutter = null;

        #region 窗体事件
        /// <summary>
        /// 截图按钮单击事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCutter_Click(object sender, EventArgs e)
        {
            // 新建一个和屏幕大小相同的图片
            Bitmap CatchBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            
            // 创建一个画板，让我们可以在画板上画图
            // 这个画板也就是和屏幕大小一样大的图片
            // 我们可以通过Graphics这个类在这个空白图片上画图
            Graphics g = Graphics.FromImage(CatchBmp);

            // 把屏幕图片拷贝到我们创建的空白图片 CatchBmp中
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));

            // 创建截图窗体
            cutter = new Cutter();

            // 指示窗体的背景图片为屏幕图片
            cutter.BackgroundImage = CatchBmp;
            // 显示窗体
            //cutter.Show();
            // 如果Cutter窗体结束，则从剪切板获得截取的图片，并显示在聊天窗体的发送框中
            if (cutter.ShowDialog() == DialogResult.OK)
            {
                IDataObject iData = Clipboard.GetDataObject();
                DataFormats.Format format = DataFormats.GetFormat(DataFormats.Bitmap);
                if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    richTextBox1.Paste(format);

                    // 清楚剪贴板的图片
                    Clipboard.Clear();
                }
            }
        }

        // 窗体加载事件处理
        // 在窗体加载时注册热键
        private void 聊天窗体_Load(object sender, EventArgs e)
        {
            uint ctrlHotKey = (uint)(KeyModifiers.Alt|KeyModifiers.Ctrl);
            // 注册热键为Alt+Ctrl+C, "100"为唯一标识热键
            HotKey.RegisterHotKey(Handle, 100, ctrlHotKey, Keys.C);
        }

        /// <summary>
        /// 窗体关闭时处理程序
        /// 窗体关闭时取消热键注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 聊天窗体_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 卸载热键
            HotKey.UnregisterHotKey(Handle, 100);
        }

        #endregion

        // 热键按下执行的方法
        private void GlobalKeyProcess()
        {
            this.WindowState = FormWindowState.Minimized;
            // 窗口最小化也需要一定时间
            Thread.Sleep(200);
            btnCutter.PerformClick();
        }

        /// <summary>
        /// 重写WndProc()方法，通过监视系统消息，来调用过程
        /// 监视Windows消息
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            //如果m.Msg的值为0x0312那么表示用户按下了热键
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    if (m.WParam.ToString() == "100")
                    {
                        GlobalKeyProcess();
                    }

                    break;
            }

            // 将系统消息传递自父类的WndProc
            base.WndProc(ref m); 
        }
    }
}
