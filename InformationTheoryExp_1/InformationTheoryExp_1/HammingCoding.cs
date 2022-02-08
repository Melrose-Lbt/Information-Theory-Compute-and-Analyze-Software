using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class HammingCoding : Form
    {
        public int[][] H;
        public int[][] G;
        public int[][] buffer;

        public HammingCoding()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subpage2 f = new Subpage2();
            f.Show();
            this.Close();
        }

        private int[][] Trans(int[][] a, int ra, int ca)
        {
            int[][] result = new int[ca][];
            for (int i = 0; i < ca; i++)
            {
                result[i] = new int[ra];
            }

            //开始转置
            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < ca; j++)
                {
                    result[j][i] = a[i][j];
                }
            }

            return result;
        }

        //Split matrix based on column
        private int[][] Split_Matrix(int[][] a, int ra, int ca)
        {
            int[][] result = new int[ra][];
            int targetc = 0;

            //寻找关系矩阵的边界
            for (int i = 0; i < ca; i++)
            {
                if (a[ra - 1][i] == 1)
                {
                    targetc = i + 1;
                    break;
                }
            }

            //开始分裂

            for (int i = 0; i < ra; i++)
            {
                result[i] = new int[ca - targetc];
            }

            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < ca - targetc; j++)
                {
                    result[i][j] = a[i][targetc + j];
                }
            }


            return result;
        }

        //Row Concat
        private int[][] Concat(int[][] a, int[][] b, int ra, int ca, int rb, int cb)
        {
            int[][] result = new int[ra][];
            for (int i = 0; i < ra; i++)
            {
                result[i] = new int[ca + cb];
            }
            //初始化矩阵
            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < ca + cb; j++)
                {
                    result[i][j] = 0;
                }
            }

            //开始链结
            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < ca + cb; j++)
                {
                    if (j < ca)
                    {
                        result[i][j] = a[i][j];
                    }
                    else
                    {
                        result[i][j] = b[i][j - ca];
                    }
                }
            }
            return result;
        }

        private int[][] Generate_I(int dim)
        {
            int[][] result = new int[dim][];

            for (int i = 0; i < dim; i++)
            {
                result[i] = new int[dim];
            }

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (i == j)
                    {
                        result[i][j] = 1;
                    }
                    else
                    {
                        result[i][j] = 0;
                    }
                }
            }


            return result;
        }

        //Matrix "x"
        private int[][] Mutiply(int[][] a, int[][] b, int ra, int ca, int rb, int cb)
        {
            int[][] Result = new int[ra][];
            for (int i = 0; i < ra; i++)
            {
                Result[i] = new int[cb];
            }
            //初始化result矩阵
            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < cb; j++)
                {
                    Result[i][j] = 0;
                }
            }


            //计算过程
            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < cb; j++)
                {
                    for (int k = 0; k < ca; k++)
                    {
                        Result[i][j] = Result[i][j] ^ (a[i][k] * b[k][j]);
                    }
                }
            }

            return Result;
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label15.Text = "";
            label14.Text = "";
            label16.Text = "";
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            string[] nk = textBox1.Text.Split(split);
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            //生成H矩阵
            int[][] Pt = new int[n-k][];

            for(int i = 0; i < n-k; i++)
            {
                Pt[i] = new int[k];
            }

            int col = 0;
            int[] pre = new int[n - k];
            int buffercnt = 0;

            //初始化buffer
            this.buffer = new int[n-k][];
            for(int i = 0; i < this.buffer.Length; i++)
            {
                this.buffer[i] = new int[100];
            }


            //产生Pt矩阵，用于与It合并成H
            while (col < k)
            {
                int sum = 0;
                for(int i = 0; i < (n - k); i++)
                {

                    Random rd = new Random();
                    Pt[i][col] = rd.Next(0, 2);
                    sum += Pt[i][col];
                    pre[i] = Pt[i][col];
                }

                if (sum > 1)
                {
                    if (Judge(pre) == -1)
                    {
                        col++;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (sum <= 1)
                {
                    continue;
                }
                if (Judge(pre) != -1)
                {
                    continue;
                }

            
            }


            int[][] P = Trans(Pt, Pt.Length, Pt[0].Length);
            int[][] It = Generate_I(n - k);
            int[][] I = Generate_I(k);
            this.H = Concat(Pt, It, Pt.Length, Pt[0].Length, It.Length, It[0].Length);
            this.G = Concat(I, P, I.Length, I[0].Length, P.Length, P[0].Length);


            for(int i = 0; i < this.H.Length; i++)
            {
                for(int j = 0; j < this.H[0].Length; j++)
                {
                    label1.Text += Convert.ToInt32(H[i][j]);
                }
                label1.Text += "\n";
            }

            for (int i = 0; i < this.G.Length; i++)
            {
                for (int j = 0; j < this.G[0].Length; j++)
                {
                    label15.Text += Convert.ToInt32(G[i][j]);
                }
                label15.Text += "\n";
            }


            int m = this.G.Length;
            int size = Convert.ToInt32(Math.Pow(2, m));
            int[][] message = new int[size][];
            //初始化message
            for (int i = 0; i < size; i++)
            {
                message[i] = new int[m];
            }

            //生成消息序列
            for (int i = 1; i < m + 1; i++)
            {
                int counter = 1;
                int index = 1;
                int Flag = 0;

                while (counter != size+1)
                {
                    if (Flag == 0)
                    {
                        message[counter - 1][i - 1] = 0;
                    }
                    if (Flag == 1)
                    {
                        message[counter - 1][i - 1] = 1;
                    }
                    if (index == size / (Convert.ToInt32(Math.Pow(2, i))))
                    {
                        Flag = 1 ^ Flag;
                        index = 1;
                        counter++;
                        continue;
                    }
                    counter++;
                    index++;
                }
            }

            //显示消息序列
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    label14.Text += Convert.ToString(message[i][j]);
                }
                label14.Text += "\n";
            }


            //根据生成矩阵生成码字
            int[][] Codewords = new int[size][];
            for (int i = 0; i < size; i++)
            {
                Codewords[i] = new int[Convert.ToInt32(nk[0])];
            }


            //计算生成矩阵
            for (int i = 0; i < size; i++)
            {
                //初始化缓冲数组
                int[] sumbuffer = new int[Convert.ToInt32(nk[0])];
                for (int s = 0; s < sumbuffer.Length; s++)
                {
                    sumbuffer[s] = 0;
                }


                for (int j = 0; j < m; j++)
                {
                    int[] buffers = new int[Convert.ToInt32(nk[0])];

                    for (int q = 0; q < buffers.Length; q++)
                    {
                        int a = message[i][j];
                        int b = this.G[j][q];
                        buffers[q] = a * b;
                        sumbuffer[q] = sumbuffer[q] ^ buffers[q];

                    }


                }
                //将生成的码字存储
                for (int q = 0; q < sumbuffer.Length; q++)
                {
                    Codewords[i][q] = sumbuffer[q];
                }
            }


            //显示生成的所有系统码字
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < Convert.ToInt32(nk[0]); j++)
                {
                    label16.Text += Convert.ToString(Codewords[i][j]);
                }
                label16.Text += "\n";
            }
        }



        //用于判断H矩阵的P部分产生的随机列向量是否合法，若合法则存储到buffer中
        //每次产生的新的随机列向量都会判断，直到产生所有的合法随机向量为止
        public int Judge(int[] a)
        {
            for (int i = 0; i < this.buffer[0].Length;i++)
            {
                int sum = 0, cnt = 0;
                for(int j = 0; j < this.buffer.Length;j++)
                {
                    if(a[j] == this.buffer[j][i])
                    {
                        cnt++;
                    }
                    sum += this.buffer[j][i];
                }
                if (sum == 0)
                {
                    for(int j = 0; j < this.buffer.Length; j++)
                    {
                        this.buffer[j][i] = a[j];
                    }
                    return -1;
                }
                if (cnt == this.buffer.Length)
                {
                    return 0;
                }

            }


            return -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label17.Text = "";
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            string[] nk = textBox1.Text.Split(split);
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);


            int[][] R = new int[1][];
            R[0] = new int[textBox2.Text.Length];
            for(int i = 0; i < textBox2.Text.Length; i++)
            {
                R[0][i] = Convert.ToInt32(Convert.ToString(textBox2.Text[i]));
            }

            int[][] p = Trans(this.H, this.H.Length, this.H[0].Length);
            int[][] result = Mutiply(R, p,
                R.Length, R[0].Length, p.Length, p[0].Length);

            int sum = 0, real = 0;
            int[] judge = new int[result[0].Length];
            //显示相乘的结果
            for(int j = 0; j < result[0].Length; j++)
            {
                label6.Text += Convert.ToString(result[0][j]);
                //sum += result[0][j];
                judge[j] = result[0][j];
            }
            int index = issame(judge);



            //判断是否全0，并指出哪个地方有错，改正
            if(index == -1)
            {
                label7.Text = "收码没有错误！";
            }
            else
            {
                if (R[0][index] == 1)
                {
                    R[0][index] = 0;
                }
                else
                {
                    R[0][index] = 1;
                }
                label7.Text = "收码在第" + Convert.ToString(n-index) + "发生错误, 正确的码字应该为：" ;

                for(int i = 0; i < R[0].Length; i++)
                {
                    label17.Text += Convert.ToString(R[0][i]);
                }
            }
        }


        private int issame(int[] a)
        {
            for(int i = 0; i < this.H[0].Length; i++)
            {
                int cnt = 0,sum = 0;
                for(int j = 0; j < this.H.Length; j++)
                {
                    if(this.H[j][i] == a[j])
                    {
                        cnt++;
                    }
                    sum += this.H[j][i];
                }
                if(cnt == 0)
                {
                    continue;
                }
                if(cnt==this.H.Length && sum != 0)
                {
                    return i;
                }
                if(cnt==this.H.Length && sum == 0)
                {
                    return -2;
                }
            }

            return -1;
        }

        private void 什么是生成矩阵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectify f = new Rectify();
            f.Show();
        }

        private void 什么是线性分组码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
