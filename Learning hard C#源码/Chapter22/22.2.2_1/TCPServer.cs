using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace _22._1
{
    public partial class TCPServer : Form
    {
        #region 变量
        // 申明变量
        private const int Port = 51388;
        private TcpListener tcpLister = null;
        private TcpClient tcpClient = null;
        IPAddress ipaddress;
        private NetworkStream networkStream = null;
        private BinaryReader reader;
        private BinaryWriter writer;

        // 申明委托
        // 显示消息
        private delegate void ShowMessage(string str);
        private ShowMessage showMessageCallback;

        // 清空消息
        private delegate void ResetMessage();
        private ResetMessage resetMessageCallBack;

        #endregion 

        public TCPServer()
        {
            InitializeComponent();

            #region 实例化委托
            // 显示消息
            showMessageCallback = new ShowMessage(showMessage);

            // 重置消息
            resetMessageCallBack = new ResetMessage(resetMessage);
            #endregion   
            
            ipaddress = IPAddress.Loopback;
            tbxserverIp.Text = ipaddress.ToString();
            tbxPort.Text = Port.ToString();
        }

        #region 定义回调函数

        // 显示消息
        private void showMessage(string str)
        {
            lstbxMessageView.Items.Add(str);
            lstbxMessageView.TopIndex = lstbxMessageView.Items.Count - 1;
        }

        // 清空消息
        private void resetMessage()
        {
            tbxMessage.Text = string.Empty;
            tbxMessage.Focus();
        }

        #endregion

        #region Click事件
        // 开始监听
        private void btnStart_Click(object sender, EventArgs e)
        {
            tcpLister = new TcpListener(ipaddress, Port);
            tcpLister.Start();
            // 启动一个线程来接受请求
            Thread acceptThread = new Thread(acceptClientConnect);
            acceptThread.Start();
        }

        // 接受请求
        private void acceptClientConnect()
        {
            try
            {
                lstbxMessageView.Invoke(showMessageCallback, "等待连接");
                tcpClient = tcpLister.AcceptTcpClient();
                if (tcpLister != null)
                {
                    lstbxMessageView.Invoke(showMessageCallback, "接收到连接");
                    networkStream = tcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                }
            }
            catch
            {
                lstbxMessageView.Invoke(showMessageCallback, "停止监听");
            }
        }

        // 关闭监听
        private void btnStop_Click(object sender, EventArgs e)
        {
            tcpLister.Stop();
        }

        // 清空消息
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbxMessageView.Items.Clear();
        }

        // 接受消息
        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                string receivemessage = reader.ReadString();

                lstbxMessageView.Invoke(showMessageCallback, receivemessage);
            }
            catch
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (writer != null)
                {
                    writer.Close();
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
                // 重新开启一个线程等待新的连接
                Thread acceptThread = new Thread(acceptClientConnect);
                acceptThread.Start();
            }
        }

        // 发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(tbxMessage.Text);
        }

        // 发送消息
        private void SendMessage(object state)
        {
            lstbxMessageView.Invoke(showMessageCallback, "正在发送");
            try
            {
                writer.Write(state.ToString());
                Thread.Sleep(5000);
                writer.Flush();
                lstbxMessageView.Invoke(showMessageCallback, "发送完毕");
                tbxMessage.Invoke(resetMessageCallBack, null);
                lstbxMessageView.Invoke(showMessageCallback, state.ToString());
            }
            catch
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (writer != null)
                {
                    writer.Close();
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
                lstbxMessageView.Invoke(showMessageCallback, "断开连接");
                // 重新开启一个线程等待新的连接
                Thread acceptThread = new Thread(acceptClientConnect);
                acceptThread.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Close();
            }
            if (writer != null)
            {
                writer.Close();
            }
            if (tcpClient != null)
            {
                // 断开连接
                tcpClient.Close();
            }

            // 启动一个线程等待接受新的请求
            Thread acceptThread = new Thread(acceptClientConnect);
            acceptThread.Start();
        }
        #endregion 
    }
}
