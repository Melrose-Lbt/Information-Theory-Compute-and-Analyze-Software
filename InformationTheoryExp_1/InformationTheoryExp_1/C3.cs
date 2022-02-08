using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class C3 : Form
    {
        public C3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemFigure2 f = new SystemFigure2();
            f.Show();
            this.Close();
        }

        private void C3_Load(object sender, EventArgs e)
        {

        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            double D = Convert.ToDouble(textBox1.Text);
            string[] p = textBox2.Text.Split(" ");
            double[] px = new double[p.Length];
            char[] split = new char[1] { ' ' };
            double[] pcx = new double[textBox4.Lines.Length * textBox4.Lines[0].Split(split).Length];
            double[] d = new double[textBox3.Lines.Length * textBox3.Lines[0].Split(split).Length];


            int cnt = 0, cntd = 0;
            for (int i = 0; i < p.Length; i++)
            {
                px[i] = Convert.ToDouble(p[i]);
            
            }

            for (int i = 0; i < textBox4.Lines.Length; i++)
            {

                for (int j = 0; j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    pcx[cnt] = Convert.ToDouble(textBox4.Lines[i].Split(split)[j]);
                    cnt++;
                }
            }

            for(int i = 0; i < textBox3.Lines.Length; i++)
            {
                for (int j = 0; j < textBox3.Lines[i].Split(split).Length; j++)
                {
                    d[cntd] = Convert.ToDouble(textBox3.Lines[i].Split(split)[j]);
                    cntd++;
                }
            }

            //calculate the D
            double sumD = 0;
            int cntD = 0;
            for (int i = 0; i < p.Length; i++)
            {
                for(int j = 0; j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    sumD += px[i] * pcx[cntD] * d[cntD];
                    cntD++;
                }
                
            }
            if (sumD > D)
            {
                label4.Text = "该假设信道不是允许实验信道！";
            }
            if (sumD <= D)
            {
                label4.Text = Convert.ToString(sumD);
            }

        }

        private void 信源熵计算工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignalEntropy f = new SignalEntropy();
            f.Show();
        }

        private void 信息率计算工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTools f = new CTools();
            f.Show();
        }
    }
}
