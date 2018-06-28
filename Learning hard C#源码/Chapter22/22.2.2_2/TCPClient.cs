using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace _22._2
{
    public partial class TCPClient : Form
    {
        #region 变量
        // 申明变量
        private TcpClient tcpClient = null;
        private NetworkStream networkStream = null;
        private BinaryReader reader;
        private BinaryWriter writer;
        private const int Port = 51388;
        IPAddress ipaddress;
        // 申明委托
        // 显示消息
        private delegate void ShowMessage(string str);
        private ShowMessage showMessageCallback;

        // 清空消息
        private delegate void ResetMessage();
        private ResetMessage resetMessageCallBack;

        #endregion 
        public TCPClient()
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
            lstbxMessageView.Items.Add(tcpClient.Client.RemoteEndPoint);
            lstbxMessageView.Items.Add(str);
            lstbxMessageView.TopIndex = lstbxMessageView.Items.Count - 1;
        }

        // 清空消息
        private void resetMessage()
        {
            tbxMessage.Text = "";
            tbxMessage.Focus();
        }

        #endregion

        #region 点击事件方法
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // 通过一个线程发起请求,多线程
            Thread connectThread = new Thread(ConnectToServer);
            connectThread.Start();
        }

        // 连接服务器方法,建立连接的过程
        private void ConnectToServer()
        {
            try
            {
                if (tbxserverIp.Text == string.Empty || tbxPort.Text == string.Empty)
                {
                    MessageBox.Show("请先输入服务器的IP地址和端口号");
                }

                IPAddress ipaddress = IPAddress.Parse(tbxserverIp.Text);
                tcpClient = new TcpClient();
                tcpClient.Connect(ipaddress, int.Parse(tbxPort.Text));

                // 延时操作
                Thread.Sleep(1000);
                if (tcpClient != null)
                {
                    MessageBox.Show("连接成功");
                    networkStream = tcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                }
            }
            catch
            {
                MessageBox.Show("连接失败，请重试");
            }
        }

        // 接受消息
        private void btnReceive_Click(object sender, EventArgs e)
        {
            Thread receiveThread = new Thread(receiveMessage);
            receiveThread.Start();
        }
        // 接受消息
        private void receiveMessage()
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
            }
        }

        // 断开连接
        private void btnDisconnect_Click(object sender, EventArgs e)
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
        }

        // 发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(tbxMessage.Text);
        }

        private void SendMessage(object state)
        {
            try
            {
                writer.Write(state.ToString());
                Thread.Sleep(5000);
                writer.Flush();

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
            }
        }

        // 清空消息
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbxMessageView.Items.Clear();
        }

        #endregion
    }
}
