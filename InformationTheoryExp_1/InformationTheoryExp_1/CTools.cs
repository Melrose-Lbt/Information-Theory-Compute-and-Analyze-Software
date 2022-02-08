using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class CTools : Form
    {
        public CTools()
        {
            InitializeComponent();
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            string[] p = textBox1.Text.Split(" ");
            double[] px = new double[p.Length];
            double[] pcx = new double[textBox4.Lines.Length * textBox4.Lines.Length];//条件概率存储空间
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            int cnt = 0;
            double sum = 0;
            //获取信源概率模型
            double entropy = 0;
            for(int i = 0; i < p.Length;i++)
            {
                px[i] = Convert.ToDouble(p[i]);
                entropy += -px[i] * Math.Log(px[i], 2);
            }


            for (int i = 0; i < textBox4.Lines.Length; i++)
            {
                double sumsub = 0;
                for (int j = 0; j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    pcx[cnt] = Convert.ToDouble(textBox4.Lines[i].Split(split)[j]);

                    sumsub += -pcx[cnt] * Math.Log(pcx[cnt], 2);
                    cnt++;
                }
                sum += px[i] * sumsub; 
            }

            label4.Text = Convert.ToString(Math.Round(entropy - sum, 2)) + " bit/sig";
        }
    }
}
