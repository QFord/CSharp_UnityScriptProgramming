namespace _22._3
{
    partial class UDPClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxlocalPort = new System.Windows.Forms.TextBox();
            this.lblocalIp = new System.Windows.Forms.Label();
            this.tbxlocalip = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstbxMessageView = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMessageSend = new System.Windows.Forms.TextBox();
            this.tbxSendtoport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSendtoIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxlocalPort
            // 
            this.tbxlocalPort.Location = new System.Drawing.Point(184, 12);
            this.tbxlocalPort.Name = "tbxlocalPort";
            this.tbxlocalPort.Size = new System.Drawing.Size(78, 21);
            this.tbxlocalPort.TabIndex = 6;
            // 
            // lblocalIp
            // 
            this.lblocalIp.AutoSize = true;
            this.lblocalIp.Location = new System.Drawing.Point(8, 18);
            this.lblocalIp.Name = "lblocalIp";
            this.lblocalIp.Size = new System.Drawing.Size(47, 12);
            this.lblocalIp.TabIndex = 5;
            this.lblocalIp.Text = "本地IP:";
            // 
            // tbxlocalip
            // 
            this.tbxlocalip.Location = new System.Drawing.Point(58, 12);
            this.tbxlocalip.Name = "tbxlocalip";
            this.tbxlocalip.Size = new System.Drawing.Size(100, 21);
            this.tbxlocalip.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(61, 115);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 21);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 21);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstbxMessageView
            // 
            this.lstbxMessageView.FormattingEnabled = true;
            this.lstbxMessageView.ItemHeight = 12;
            this.lstbxMessageView.Location = new System.Drawing.Point(10, 142);
            this.lstbxMessageView.Name = "lstbxMessageView";
            this.lstbxMessageView.Size = new System.Drawing.Size(262, 112);
            this.lstbxMessageView.TabIndex = 22;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(217, 75);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(55, 21);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMessageSend
            // 
            this.tbxMessageSend.Location = new System.Drawing.Point(58, 77);
            this.tbxMessageSend.Name = "tbxMessageSend";
            this.tbxMessageSend.Size = new System.Drawing.Size(153, 21);
            this.tbxMessageSend.TabIndex = 20;
            // 
            // tbxSendtoport
            // 
            this.tbxSendtoport.Location = new System.Drawing.Point(184, 37);
            this.tbxSendtoport.Name = "tbxSendtoport";
            this.tbxSendtoport.Size = new System.Drawing.Size(78, 21);
            this.tbxSendtoport.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "：";
            // 
            // tbxSendtoIp
            // 
            this.tbxSendtoIp.Location = new System.Drawing.Point(58, 36);
            this.tbxSendtoIp.Name = "tbxSendtoIp";
            this.tbxSendtoIp.Size = new System.Drawing.Size(100, 21);
            this.tbxSendtoIp.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "发送到：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "：";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(211, 115);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(61, 21);
            this.btnReceive.TabIndex = 27;
            this.btnReceive.Text = "接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "内容：";
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstbxMessageView);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMessageSend);
            this.Controls.Add(this.tbxSendtoport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSendtoIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxlocalPort);
            this.Controls.Add(this.lblocalIp);
            this.Controls.Add(this.tbxlocalip);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxlocalPort;
        private System.Windows.Forms.Label lblocalIp;
        private System.Windows.Forms.TextBox tbxlocalip;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstbxMessageView;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMessageSend;
        private System.Windows.Forms.TextBox tbxSendtoport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSendtoIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label4;
    }
}

