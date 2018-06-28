using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _23._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void PenUse()
        {
            Pen myPen = new Pen(Color.Black);
            Pen myPen2 = new Pen(Color.Black, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.FillEllipse(myBrush, 0, 0, 100, 100);
        }
    }
}
