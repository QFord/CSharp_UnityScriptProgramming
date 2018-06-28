using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._6
{
    public partial class Form1 : Form
    {
        int DownloadSize = 0;
        string downloadPath = null;
        long totalSize = 0;
        FileStream filestream;

        CancellationTokenSource cts = null;
        Task task = null;

        public Form1()
        {
            InitializeComponent();

            string url = "http://download.microsoft.com/download/7/0/3/703455ee-a747-4cc8-bd3e-98a615c3aedb/dotNetFx35setup.exe";

            txbUrl.Text = url;
            this.btnPause.Enabled = false;

            GetTotalSize();
            downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Path.GetFileName(this.txbUrl.Text.Trim());
            if (File.Exists(downloadPath))
            {
                FileInfo fileInfo = new FileInfo(downloadPath);
                DownloadSize = (int)fileInfo.Length;
                progressBar1.Value = (int)((float)DownloadSize / (float)totalSize * 100);
            }
        }

        private async void btnDownLoad_Click(object sender, EventArgs e)
        {
            filestream = new FileStream(downloadPath, FileMode.OpenOrCreate);
            this.btnDownLoad.Enabled = false;
            this.btnPause.Enabled = true;

            filestream.Seek(DownloadSize, SeekOrigin.Begin);

            cts = new CancellationTokenSource();

            await DownLoadFileAsync(txbUrl.Text.Trim(), cts.Token, new Progress<int>(p => progressBar1.Value = p));
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            cts.Cancel(); // 发出一个取消请求
        }

        // C# 5.0 使用async和await方式实现下载文件
        private async Task DownLoadFileAsync(string url, CancellationToken ct, IProgress<int> progress)
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

                response = (HttpWebResponse)await request.GetResponseAsync();
                responseStream = response.GetResponseStream();
                int readSize = 0;
                while (true)
                {
                    if (ct.IsCancellationRequested == true)
                    {
                        MessageBox.Show(String.Format("下载暂停，下载的文件地址为：{0}\n 已经下载的字节数为: {1}字节", downloadPath, DownloadSize));
                        response.Close();
                        filestream.Close();

                        this.btnDownLoad.Enabled = true;
                        this.btnPause.Enabled = false;
                        break;
                    }

                    readSize = await responseStream.ReadAsync(bufferBytes, 0, bufferBytes.Length);
                    if (readSize > 0)
                    {
                        DownloadSize += readSize;
                        int percentComplete = (int)((float)DownloadSize / (float)totalSize * 100);
                        await filestream.WriteAsync(bufferBytes, 0, readSize);

                        progress.Report(percentComplete); // 报告进度
                    }
                    else
                    {
                        MessageBox.Show(String.Format("下载已完成，下载的文件地址为：{0}，文件的总字节数为: {1}字节", downloadPath, totalSize));

                        this.btnDownLoad.Enabled = false;
                        this.btnPause.Enabled = false;
                        response.Close();
                        filestream.Close();
                        break;
                    }
                }
            }
            catch (AggregateException ex)
            {
                ex.Handle(e => e is OperationCanceledException);
            }
        }

        private void GetTotalSize() //  获得文件总大小
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(txbUrl.Text.Trim());
            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            totalSize = response.ContentLength;
            response.Close();
        }
    }
}
