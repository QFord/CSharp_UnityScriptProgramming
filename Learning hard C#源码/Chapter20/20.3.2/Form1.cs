using System;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace _20._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbUrl.Text = "http://download.microsoft.com/download/7/0/3/703455ee-a747-4cc8-bd3e-98a615c3aedb/dotNetFx35setup.exe";
        }

        // 定义用来实现异步编程的委托
        private delegate string AsyncMethodCaller(string fileurl);

        SynchronizationContext sc;
        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            rtbState.Text = "下载中.....";
            btnDownLoad.Enabled = false; // 把按钮设置不可用
            if (txbUrl.Text == String.Empty)
            {
                MessageBox.Show("请先输入下载地址！");
                return;
            }
            sc = SynchronizationContext.Current; // 获得调用线程的同步上下文对象
            AsyncMethodCaller methodCaller = new AsyncMethodCaller(DownLoadFileAsync);
            methodCaller.BeginInvoke(txbUrl.Text.Trim(), GetResult, null);
            
        }

        public string DownLoadFileAsync(string url)
        {
            int BufferSize = 2048;
            byte[] BufferRead = new byte[BufferSize];
            string savepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\dotNetFx35setup.exe";
            FileStream filestream = null;
            HttpWebResponse myWebResponse = null;
            if (File.Exists(savepath))
            {
                File.Delete(savepath);
            }

            filestream = new FileStream(savepath, FileMode.OpenOrCreate);
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                if (myHttpWebRequest != null)
                {
                    myWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                    Stream responseStream = myWebResponse.GetResponseStream();
                    int readSize = responseStream.Read(BufferRead, 0, BufferSize);
                    while (readSize > 0)
                    {
                        filestream.Write(BufferRead, 0, readSize);
                        readSize = responseStream.Read(BufferRead, 0, BufferSize);
                    }
                }
                // 执行该方法的线程是线程池线程，该线程不是与创建richTextBox控件的线程不是一个线程
                return string.Format("文件下载完成，文件大小为:{0}, 下载路径为：{1}", filestream.Length, savepath);
            }
            catch (Exception e)
            {
                return string.Format ("下载过程中发生异常，异常信息为: {0}" ,e.Message);
            }
            finally
            {
                if (myWebResponse != null)
                {
                    myWebResponse.Close();
                }
                if (filestream != null)
                {
                    filestream.Close();
                }
            }
        }

        // 异步操作完成时执行的方法
        private void GetResult(IAsyncResult result)
        {
            AsyncMethodCaller caller = (AsyncMethodCaller)((AsyncResult)result).AsyncDelegate;

            // 调用EndInvoke去等待异步调用完成并且获得返回值
            // 如果异步调用尚未完成，则 EndInvoke 会一直阻止调用线程，直到异步调用完成
            string returnstring = caller.EndInvoke(result);

            // 通过获得GUI线程的同步上下文的派生对象，
            // 然后调用Post方法来使更新GUI操作方法由GUI 线程去执行
            sc.Post(ShowState, returnstring);
        }

        // 显示结果到richTextBox
        // 因为该方法是由GUI线程执行的，所以当然就可以访问窗体控件了
        private void ShowState(object result)
        {
            rtbState.Text = result.ToString();
            btnDownLoad.Enabled = true;
        }
    }
}
