using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class LinearCoding : Form
    {

        public int[][] p;
        public LinearCoding()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subpage2 f = new Subpage2();
            f.Show();
            this.Close();
        }

        private void MemoryCal_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            int m = Convert.ToInt32(textBox2.Text);
            char[] split = new char[1] { ' ' };//分割需要用到的字符
            string[] nk = textBox1.Text.Split(split);
            int[][] Generate = new int[textBox4.Lines.Length][];
 
            for(int i = 0; i < textBox4.Lines.Length;i++)
            {
                Generate[i] = new int[textBox4.Lines[0].Split(split).Length];
            }


            int size = Convert.ToInt32(Math.Pow(2, m));
            int[][] message = new int[size][];
            //初始化message
            for(int i = 0; i < size; i++)
            {
                message[i] = new int[m];
            }

            //生成消息序列
            for(int i = 1; i < m+1; i++)
            {
                int counter = 1;
                int index = 1;
                int Flag = 0;

                while (counter != 9)
                {
                    if(Flag==0){
                        message[counter-1][i - 1] = 0;
                    }
                    if(Flag==1){
                        message[counter-1][i - 1] = 1;
                    }
                    if (index == size / (Convert.ToInt32(Math.Pow(2, i))))
                    {
                        Flag = 1^Flag;
                        index = 1;
                        counter++;
                        continue;
                    }
                    counter++;
                    index++;
                }
            }

            //显示消息序列
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    label13.Text += Convert.ToString(message[i][j]);
                }
                label13.Text += "\n";
            }
  

            //获取生成矩阵所有元素
            for (int i = 0; i < textBox4.Lines.Length; i++)
            {

                for (int j = 0; j < textBox4.Lines[i].Split(split).Length; j++)
                {
                    Generate[i][j] = Convert.ToInt32(textBox4.Lines[i].Split(split)[j]);
                }
            }

            //根据生成矩阵生成码字
            int[][] Codewords = new int[size][];
            int[][] SystemcodeWords = new int[size][];
            for(int i = 0; i < size; i++)
            {
                Codewords[i] = new int[Convert.ToInt32(nk[0])];
                SystemcodeWords[i] = new int[Convert.ToInt32(nk[0])];
            }

            
            //计算生成矩阵
            for(int i = 0; i < size; i++)
            {
                //初始化缓冲数组
                int[] sumbuffer = new int[Convert.ToInt32(nk[0])];
                for(int s = 0; s < sumbuffer.Length; s++)
                {
                    sumbuffer[s] = 0;
                }


                for(int j = 0; j < m; j++)
                {
                    int[] buffer = new int[Convert.ToInt32(nk[0])];

                    for(int k = 0; k < buffer.Length; k++)
                    {
                        int a = message[i][j];
                        int b = Generate[j][k];
                        buffer[k] = a * b;
                        sumbuffer[k] = sumbuffer[k] ^ buffer[k];

                    }

                 
                }
                //将生成的码字存储
                for(int k = 0; k < sumbuffer.Length; k++)
                {
                    Codewords[i][k] = sumbuffer[k];
                }
            }


            //显示生成的所有系统码字
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < Convert.ToInt32(nk[0]); j++)
                {
                    label14.Text += Convert.ToString(Codewords[i][j]);
                }
                label14.Text += "\n";
            }

            //根据系统生成矩阵求校验矩阵
            this.p = Split_Matrix(Generate,Generate.Length,Generate[0].Length);
            this.p = Trans(this.p, this.p.Length, this.p[0].Length);
            int[][] I = Generate_I(Convert.ToInt32(nk[0]) - Convert.ToInt32(nk[1]));
            this.p = Concat(this.p, I, this.p.Length, this.p[0].Length, I.Length, I[0].Length);
            
            for(int i = 0; i < this.p.Length; i++)
            {
                for(int j = 0; j < this.p[0].Length; j++)
                {
                    label15.Text += Convert.ToString(this.p[i][j]) + " ";
                }
                label15.Text += "\n";
            }
            



        }

        //Matrix "x"
        private int[][] Mutiply(int[][] a, int[][] b, int ra, int ca, int rb, int cb)
        {
            int[][] Result = new int[ra][];
            for(int i = 0; i < ra; i++)
            {
                Result[i] = new int[cb];
            }
            //初始化result矩阵
            for(int i = 0; i < ra;i++)
            {
                for(int j = 0; j < cb; j++)
                {
                    Result[i][j] = 0;
                }
            }


            //计算过程
            for(int i = 0; i < ra; i++)
            {
                for(int j = 0; j < cb; j++)
                {
                    for(int k = 0; k < ca; k++)
                    {
                        Result[i][j] = Result[i][j] ^( a[i][k] * b[k][j]);
                    }
                }
            }

            return Result;
        }

        private int[][] Generate_I(int dim)
        {
            int[][] result = new int[dim][];

            for(int i = 0; i < dim; i++)
            {
                result[i] = new int[dim];
            }

            for(int i = 0; i < dim; i++)
            {
                for(int j = 0; j < dim; j++)
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

        //Row Concat
        private int[][] Concat(int[][] a, int[][] b, int ra,int ca,int rb,int cb)
        {
            int[][] result = new int[ra][];
            for(int i = 0; i < ra; i++)
            {
                result[i] = new int[ca + cb];
            }
            //初始化矩阵
            for(int i = 0; i < ra; i++)
            {
                for(int j = 0; j < ca + cb; j++)
                {
                    result[i][j] = 0;
                }
            }

            //开始链结
            for(int i = 0; i < ra; i++)
            {
                for(int j = 0; j < ca + cb; j++)
                {
                    if (j < ca)
                    {
                        result[i][j] = a[i][j];
                    }
                    else
                    {
                        result[i][j] = b[i][j-ca];
                    }
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
            for(int i = 0; i < ca; i++)
            {
                if(a[ra-1][i] == 1)
                {
                    targetc = i+1;
                    break;
                }
            }

            //开始分裂

            for(int i = 0; i < ra; i++)
            {
                result[i] = new int[ca - targetc];
            }

            for(int i = 0; i < ra; i++)
            {
                for(int j = 0; j < ca - targetc; j++)
                {
                    result[i][j] = a[i][targetc + j];
                }
            }


            return result;
        }

        //Matrix.T
        private int[][] Trans(int[][] a, int ra, int ca)
        {
            int[][] result = new int[ca][];
            for (int i = 0; i < ca; i++)
            {
                result[i] = new int[ra];
            }

            //开始转置
            for(int i = 0; i < ra; i++)
            {
                for(int j = 0; j < ca; j++)
                {
                    result[j][i] = a[i][j];
                }
            }

            return result;
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label17.Text = "r与H转置的乘积为：";
            label16.Text = "";
            int[][] r = new int[1][];
            r[0] = new int[textBox3.Text.Length];
            for(int i = 0; i < textBox3.Text.Length; i++)
            {
                r[0][i] = Convert.ToInt32(Convert.ToString(textBox3.Text[i]));
            }

            int sum = 0;
            int[][] pt = Trans(this.p, this.p.Length, this.p[0].Length);
            int[][] result = Mutiply(r, pt, 1, r[0].Length, pt.Length, pt[0].Length);
            for(int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < result[0].Length;j++) 
                {
                    if(result[i][j] != 0)
                    {
                        sum++;
                    }
                    label17.Text += Convert.ToString(result[i][j]);
                }
                label17.Text += "\n";
            }

            
            if (sum == 0)
            {
                label16.Text = "收码是系统码字！";
            }
            else
            {
                label16.Text = "收码不是系统码字！";
            }
        }

        private void 什么是线性分组码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Linearcoding1 f = new Linearcoding1();
            f.Show();
        }

        private void 线性分组码的校验原理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectify f = new Rectify();
            f.Show();
        }
    }
}
