using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class SystemFigure2 : Form
    {
        public SystemFigure2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard f = new DashBoard();
            f.Show();
            this.Close();
        }

        private void asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignalEntropy f = new SignalEntropy();
            f.Show();
        }

        private void 编码工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encoder_Decoder f = new Encoder_Decoder();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1 f = new C1();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C2 f = new C2();
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C3 f = new C3();
            f.Show();
            this.Close();
        }

        private void 信息率计算工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTools f = new CTools();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subpage2 f = new Subpage2();
            f.Show();
            this.Close();
        }
    }
}
