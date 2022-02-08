using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class C1 : Form
    {
        public C1()
        {
            InitializeComponent();
        }

        private void 信息率计算工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTools f = new CTools();
            f.Show();
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            double[] pcx = new double[textBox4.Lines.Length * textBox4.Lines.Length];//条件概率存储空间
            char[] split = new char[1] { ' ' };//分割需要用到的字符

            double sum = 0;

            for (int j = 0; j < num; j++)
            {
                pcx[j] = Convert.ToDouble(textBox4.Lines[0].Split(split)[j]);

                sum += -pcx[j] * Math.Log(pcx[j], 2);
            }
            label4.Text = Convert.ToString(Math.Round(Math.Log(num, 2) - sum, 2)) + " bit/sig";
        }

        private void 信源熵计算工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignalEntropy f = new SignalEntropy();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemFigure2 f = new SystemFigure2();
            f.Show();
            this.Close();
        }

        private void 对称离散无记忆信道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SymmeDisMC f = new SymmeDisMC();
            f.Show();
        
        }
    }
}
