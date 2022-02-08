using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class Markov : Form
    {
        public Markov()
        {
            InitializeComponent();
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            string[] p = textBox1.Text.Split(" ");
            double[] w = new double[p.Length];
            double[] s = new double[p.Length];
            double[] pcx = new double[textBox4.Lines.Length * textBox4.Lines.Length];//条件概率存储空间
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            int cnt = 0;
            double sum = 0;
            //获取概率矢量

            for (int i = 0; i < p.Length; i++)
            {
                w[i] = Convert.ToDouble(p[i]);
            }

            for (int i = 0; i < textBox4.Lines.Length; i++)
            {
                for (int j = 0; j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    pcx[cnt] = Convert.ToDouble(textBox4.Lines[i].Split(split)[j]);
                    cnt++;
                }
            }

            for(int i = 0; i < s.Length; i++)
            {
                double h = 0;
                for(int j = 0; j < s.Length; j++)
                {
                    if (pcx[3 * i + j] == 0)
                    {
                        continue;
                    }
                    if (pcx[3 * i + j] != 0)
                    {
                        h += -pcx[3 * i + j] * Math.Log(pcx[3 * i + j], 2);
                    }
                }
                s[i] = h;
                sum += s[i] * w[i];
            }

            label4.Text = Convert.ToString(Math.Round(sum, 2)) + " bit/sig";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemFigure f = new SystemFigure();
            f.Show();
            this.Close();
        }
    }
}
