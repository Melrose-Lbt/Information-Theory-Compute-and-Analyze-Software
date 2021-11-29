using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class DisSequenceEntropy : Form
    {
        public DisSequenceEntropy()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SystemFigure f1 = new SystemFigure();
            f1.Show();
            this.Close();
        }

        private void MemorylessCal_Click(object sender, EventArgs e)
        {
            string[] arr = new string[textBox1.Lines.Length];
            double[] px = new double[textBox1.Lines.Length];
            double[] y = new double[textBox1.Lines.Length];
            double sum = 0,sump = 0;
            double L = 0;
            L = Convert.ToDouble(textBox2.Text);

            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                arr[i] = textBox1.Lines[i];
                px[i] = Convert.ToDouble(arr[i]);
                y[i] = -px[i] * Math.Log(px[i], 2);
                sum += y[i];
                sump += px[i];
            }
            sum = Math.Round(sum, 3);
            if (sump == 1)
            {
                label4.Text = "平均消息熵H(X^L)：";
                label12.Text = Convert.ToString(L * sum) + "bit/sig";
                label5.Text = "平均符号熵H(X)：";
                label13.Text = Convert.ToString(sum) + "bit/sig";
            }
            else
            {
                label5.Text = "信源概率不符合完备性！";
                label4.Text = " ";
            }
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            string[] arr = new string[textBox3.Lines.Length];
            double[] px = new double[textBox3.Lines.Length];
            double[] y = new double[textBox3.Lines.Length];
            double[] pcx = new double[textBox3.Lines.Length * textBox3.Lines.Length];//条件概率存储空间
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            int cnt = 0;
            double sum1 = 0, sum = 0, sump = 0;//sump为判断概率完备性的变量
            double L = 0;
            L = Convert.ToDouble(textBox5.Text);

           
            for (int i = 0; i < textBox3.Lines.Length; i++)
            {
                arr[i] = textBox3.Lines[i];
                px[i] = Convert.ToDouble(arr[i]);
                y[i] = -px[i] * Math.Log(px[i], 2);
                sum1 += y[i];  //单符号信源熵
                sump += px[i];
            }
            
            //从矩阵当中得到每一个条件概率，并存放到pcx当中
            for(int i = 0; i < textBox3.Lines.Length; i++)
            {
                double sumsub = 0;
                for(int j = 0;j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    pcx[cnt] = Convert.ToDouble(textBox4.Lines[i].Split(split)[j]);
                    
                    sumsub += -pcx[cnt] * Math.Log(pcx[cnt], 2);
                    cnt++;
                }
                sum += px[i] * sumsub;  //双符号信源条件熵
            }
            
            sum = Math.Round(sum, 3);
            sum1 = Math.Round(sum1, 3);
            if (sump == 1)
            {
                if (L == 1)
                {
                    label10.Text = "平均消息熵H(X^L)：";
                    label14.Text = Convert.ToString(L * sum1) + "bit/sig";
                    label11.Text = "平均符号熵H(X)：";
                    label15.Text = Convert.ToString(sum1) + "bit/sig";
                }
                if (L > 1)
                {
                    label10.Text = "平均消息熵H(X^L)：";
                    label14.Text = Convert.ToString(Math.Round((L-1)*sum+sum1,3)) + "bit/sig";
                    label11.Text = "平均符号熵H(X)：";
                    label15.Text = Convert.ToString(Math.Round((sum1+ (L - 1) * sum)/L,3)) + "bit/sig";
                }
            }
            else
            {
                label11.Text = "信源概率不符合完备性！";
                label10.Text = " ";
            }
        }
    }
}
