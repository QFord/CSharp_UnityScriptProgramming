using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._5
{
    public partial class Form1 : Form
    {
        int DownloadSize = 0;
        string downloadPath = null;
        long totalSize = 0;
        FileStream filestream;

        CancellationTokenSource cts = null;
        Task task = null;

        SynchronizationContext sc;

        public Form1()
        {
            InitializeComponent();

            string url = "http://download.microsoft.com/download/7/0/3/703455ee-a747-4cc8-bd3e-98a615c3aedb/dotNetFx35setup.exe";
            txbUrl.Text = url;
            this.btnPause.Enabled = false;

            // Get Total Size of the download file
            GetTotalSize();
            downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Path.GetFileName(this.txbUrl.Text.Trim());
            if (File.Exists(downloadPath))
            {
                FileInfo fileInfo = new FileInfo(downloadPath);
                DownloadSize = (int)fileInfo.Length;
                progressBar1.Value = (int)((float)DownloadSize / (float)totalSize * 100);
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            filestream = new FileStream(downloadPath, FileMode.OpenOrCreate);
            this.btnDownLoad.Enabled = false;
            this.btnPause.Enabled = true;

            filestream.Seek(DownloadSize, SeekOrigin.Begin);

            // 捕捉调用线程的同步上下文派生对象
            sc = SynchronizationContext.Current;
            cts = new CancellationTokenSource();

            // 使用指定的操作初始化新的 Task。
            task = new Task(() =>
            DownloadFileWithTAP(txbUrl.Text.Trim(), cts.Token, new Progress<int>(p =>
            {
                sc.Post(new SendOrPostCallback((result) => progressBar1.Value = (int)result), p);
            }))); // 通过同步上文文的Post方法把更新UI的方法让主线程执行

            // 启动 Task，并将它安排到当前的 TaskScheduler 中执行。 
            task.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            cts.Cancel(); // 发出一个取消请求
        }

        // TAP方式实现下载文件
        public void DownloadFileWithTAP(string url, CancellationToken ct, IProgress<int> progress)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream responseStream = null;
            int bufferSize = 2048;
            byte[] bufferBytes = new byte[bufferSize];
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                if (DownloadSize != 0)
                {
                    request.AddRange(DownloadSize);
                }

                response = (HttpWebResponse)request.GetResponse();
                responseStream = response.GetResponseStream();
                int readSize = 0;
                while (true)
                {
                    if (ct.IsCancellationRequested == true) // 收到取消请求则退出异步操作
                    {
                        MessageBox.Show(String.Format("下载暂停，下载的文件地址为：{0}\n 已经下载的字节数为: {1}字节", downloadPath, DownloadSize));

                        response.Close();
                        filestream.Close();
                        sc.Post((state) =>
                        {
                            this.btnDownLoad.Enabled = true;
                            this.btnPause.Enabled = false;
                        }, null); // 通过同步上文文的Post方法把更新UI的方法让主线程执行

                        break; // 退出异步操作
                    }

                    readSize = responseStream.Read(bufferBytes, 0, bufferBytes.Length);
                    if (readSize > 0)
                    {
                        DownloadSize += readSize;
                        int percentComplete = (int)((float)DownloadSize / (float)totalSize * 100);
                        filestream.Write(bufferBytes, 0, readSize);

                        progress.Report(percentComplete);  // 报告进度
                    }
                    else
                    {
                        MessageBox.Show(String.Format("下载已完成，下载的文件地址为：{0}，文件的总字节数为: {1}字节", downloadPath, totalSize));

                        sc.Post((state) =>
                        {
                            this.btnDownLoad.Enabled = false;
                            this.btnPause.Enabled = false;
                        }, null);

                        response.Close();
                        filestream.Close();
                        break;
                    }
                }
            }
            catch (AggregateException ex)
            {
                // 调用Cancel方法会抛出OperationCanceledException异常
                // 这里将任何OperationCanceledException对象都视为以处理
                ex.Handle(e => e is OperationCanceledException);
            }
        }

        private void GetTotalSize()  //  获得文件总大小
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(txbUrl.Text.Trim());
            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            totalSize = response.ContentLength;
            response.Close();
        }
    }
}
