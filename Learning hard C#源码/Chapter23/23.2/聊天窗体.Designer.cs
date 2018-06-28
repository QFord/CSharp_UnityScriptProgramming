namespace SnippingTool
{
    partial class 聊天窗体
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(聊天窗体));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCutter = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.btnCutter);
            this.panel1.Location = new System.Drawing.Point(1, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 25);
            this.panel1.TabIndex = 3;
            // 
            // btnCutter
            // 
            this.btnCutter.Image = ((System.Drawing.Image)(resources.GetObject("btnCutter.Image")));
            this.btnCutter.Location = new System.Drawing.Point(246, 0);
            this.btnCutter.Name = "btnCutter";
            this.btnCutter.Size = new System.Drawing.Size(25, 21);
            this.btnCutter.TabIndex = 0;
            this.btnCutter.Tag = "";
            this.toolTip1.SetToolTip(this.btnCutter, "屏幕截图 Ctrl + Alt + C");
            this.btnCutter.UseVisualStyleBackColor = true;
            this.btnCutter.Click += new System.EventHandler(this.btnCutter_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(1, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 85);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // 聊天窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "聊天窗体";
            this.Text = "聊天窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.聊天窗体_FormClosing);
            this.Load += new System.EventHandler(this.聊天窗体_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCutter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

