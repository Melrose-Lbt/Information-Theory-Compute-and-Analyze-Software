using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class Kraft : Form
    {
        public Kraft()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EDcoderHome f = new EDcoderHome();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LenofSignal = textBox1.Lines[0].Length;
            string[] lenOfCode = textBox2.Lines[0].Split(" ");
            int[] len = new int[LenofSignal];
            int m = Convert.ToInt32(textBox3.Lines[0]);
            for(int i = 0; i < textBox1.Lines[0].Length; i++)
            {
                len[i] = Convert.ToInt32(lenOfCode[i]);
            }
            double sum = 0;
            for(int i = 0; i < LenofSignal; i++)
            {
                sum += 1/Math.Pow(m, len[i]);
            }
            if (sum <= 1)
            {
                label10.Text = "求和得到的值为" + Convert.ToString(Math.Round(sum, 2)) + ", 该编码方式存在唯一可译码。";
            }
            if (sum > 1)
            {
                label10.Text = "求和得到的值为" + Convert.ToString(Math.Round(sum, 2)) + ", 该编码方式不存在唯一可译码！";
            }
        }
    }
}
