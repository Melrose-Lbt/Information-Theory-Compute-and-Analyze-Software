using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class RecurrentCoding : Form
    {
        public int[][] G;
        public RecurrentCoding()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Subpage2 f = new Subpage2();
            f.Show();
            this.Close();
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            label16.Text = "";
            label14.Text = "";
            label1.Text = "";
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            string[] nk = textBox1.Text.Split(split);
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int m = k;
            int size = Convert.ToInt32(Math.Pow(2, m));
            int[][] message = new int[size][];


            //生成多项式指数数组
            int[] poly = new int[n];
            for(int i = 0; i < n; i++)
            {
                poly[i] = Convert.ToInt32(Convert.ToString(textBox2.Text[i]));
            }

            //生成生成矩阵G
            this.G = new int[k][];
            for(int i = 0; i < k; i++)
            {
                this.G[i] = new int[n];
            }
            for(int i = 0; i < k; i++)
            {
                Move(i, k - i - 1, poly);
            }

            //显示生成矩阵
            for(int i = 0; i < k; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    label1.Text += Convert.ToString(this.G[i][j]);
                }
                label1.Text += "\n";
            }



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

                while (counter != size + 1)
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



            //生成码字空间
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

        public void Move(int row, int step, int[] Original)
        {
            int[] buffer = new int[this.G[0].Length];
            for(int i = 0; i < this.G[0].Length; i++)
            {
                buffer[i] = Original[i];
            }
            for(int i = 0; i < step; i++)
            {
                int[] temp = new int[this.G[0].Length];
                for(int j = this.G[0].Length-1; j > 0; j--)
                {
                    temp[j - 1] = buffer[j];
                    
                }
                temp[this.G[0].Length - 1] = buffer[0];

                for(int k = 0; k < this.G[0].Length; k++)
                {
                    buffer[k] = temp[k];
                }
            }

            for(int k = 0; k < this.G[0].Length; k++)
            {
                this.G[row][k] = buffer[k];
            }
        }

        private void 非系统码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecurrentCoding1 f = new RecurrentCoding1();
            f.Show();
        }
    }
}
