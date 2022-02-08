using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class C2 : Form
    {
        public C2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemFigure2 f = new SystemFigure2();
            f.Show();
            this.Close();
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            double[] pcx = new double[num * textBox4.Lines[0].Split(split).Length];//条件概率存储空间
            double[] pcxl = new double[textBox4.Lines[0].Split(split).Length];
            int[] visited = new int[textBox4.Lines[0].Split(split).Length];//用来表示该列是否以及被合并过
            int cnt = 0;
            double sum = 0, NM = 0;
            //获取转移概率矩阵所有元素
            for (int i = 0; i < textBox4.Lines.Length; i++)
            {
                
                for (int j = 0; j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    pcx[cnt] = Convert.ToDouble(textBox4.Lines[i].Split(split)[j]);
                    cnt++;
                }
            }

            //求矩阵中一行的熵，保存到sum中
            for (int j = 0; j < textBox4.Lines[0].Split(split).Length; j++)
            {
                pcxl[j] = Convert.ToDouble(textBox4.Lines[0].Split(split)[j]);

                sum += -pcxl[j] * Math.Log(pcx[j], 2);
            }

            int len = textBox4.Lines[0].Split(split).Length;
            //分解矩阵算法
            for (int i = 0; i < len; i++)
            {
                //该列元素全部相同
                if(IsSame(pcx,i,num, len) == 1 && visited[i] == 0)
                {
                    NM += pcx[i] * Math.Log(num * pcx[i], 2);
                }
                //该列元素不同
                if(IsSame(pcx, i, num, len) == 0 && visited[i] == 0)
                {
                    int counter = 0;
                    for(int j=i+1;j< len; j++)
                    {
                        if(IsSame(pcx, j, num, len) == 0 && visited[i] == 0)
                        {
                            if(IsSame2(pcx,pcx,i,j,num, len) == 1)
                            {
                                visited[j] = 1;
                                counter++;
                            }
                        }
                    }
                    if(counter == num-1)
                    {
                        double N = 0;
                        for(int k = 0; k < num; k++)
                        {
                            N += pcx[i + k * len];
                        }

                        NM += N * Math.Log(N, 2);
                    }

                }
                visited[i] = 1;
            }

            double C = Math.Log(num, 2) - sum - NM;
            label4.Text = Convert.ToString(Math.Round(C, 3)) + " bit/sig";

        }

        public int IsSame2(double[] p, double[] t, int p_index, int t_index, int lenR, int lenC)
        {
            int counter = 0;
            for(int i = 0; i < lenR; i++)
            {
                for(int j = 0; j < lenR; j++)
                {
                    if(p[p_index + i*lenC] == t[t_index + j*lenC])
                    {
                        counter++;
                    }
                }
            }
            if(counter == lenR)
            {
                return 1;
            }
            return 0;
        }

        //寻找一列中是否存在不同的元素
        public int IsSame(double[] p, int index, int lenR, int lenC)
        {
            double values = p[index];
            for(int i = 0; i < lenR; i++)
            {
                if(values != p[index + i*lenC])
                {
                    return 0;//存在返回0
                }
            }
            return 1;//不存在返回1
        }

        //判断两个矩阵是否相同
        public int CheckMatrix(double[] a, double[] b)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return 0;
                }
            }
            return 1;
        }

        private void 准对称离散无记忆信道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnSymmeDisMC f = new UnSymmeDisMC();
            f.Show();
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
