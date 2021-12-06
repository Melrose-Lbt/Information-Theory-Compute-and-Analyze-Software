using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class Encoder_Decoder : Form
    {
        public Encoder_Decoder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemFigure f1 = new SystemFigure();
            f1.Show();
            this.Close();
        }

        private void Huffman_Encoder_Click(object sender, EventArgs e)
        {
            label6.Text = " ";
            string arr = EncodeTextbox.Lines[0];
            Huffman huf = new Huffman(arr, EncodeTextbox.Lines[0].Length,ProbOfHuff.Lines[0]);
            string[] code = huf.CodeList();
            for(int i = 0; i < code.Length; i++)
            {
                label6.Text += huf.message[i] + ":" + code[i] + "\n";
            }
        }

        private void HUFEncode_Click(object sender, EventArgs e)
        {
            hufcodelabel.Text = " "; /* clear label */ 
            string arr = EncodeTextbox.Lines[0];
            Huffman huf = new Huffman(arr, EncodeTextbox.Lines[0].Length, ProbOfHuff.Lines[0]);
            string[] code = huf.CodeList();

            string mess = EncodeBox.Lines[0];
            string[] signal = new string[EncodeBox.Lines[0].Length];
            for (int i = 0; i < EncodeBox.Lines[0].Length; i++)     /*split the message into single word*/
            {
                signal[i] = mess.Substring(i, 1);
            }


            for (int i = 0; i < EncodeBox.Lines[0].Length; i++)
            {
                for(int j = 0;j< EncodeTextbox.Lines[0].Length; j++)
                {
                    if(signal[i] == huf.message[j])
                    {
                        hufcodelabel.Text += code[j];
                    }
                }
            }
        }

        private void Huffman_Decoder_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            string arr = EncodeTextbox.Lines[0];
            Huffman huf = new Huffman(arr, EncodeTextbox.Lines[0].Length, ProbOfHuff.Lines[0]);
            string[] code = huf.CodeList();

            string mess = DecodeBox.Lines[0];
            string[] signal = new string[DecodeBox.Lines[0].Length];
            for (int i = 0; i < DecodeBox.Lines[0].Length; i++)     /*split the message into single word*/
            {
                signal[i] = mess.Substring(i, 1);
            }


            int j = 0;
            string message = "";
            while (j < DecodeBox.Lines[0].Length)
            {
                int k = 2 * huf.LenOfMess - 1;
                while (huf.tree[k].leftchild != 0 && huf.tree[k].rightchild != 0)
                {
                    /*判断该处的代码是0还是1，0往左边走，1往右边走*/
                    if (signal[j] == "1")
                    {
                        k = huf.tree[k].rightchild;
                    }
                    if (signal[j] == "0")
                    {
                        k = huf.tree[k].leftchild;
                    }
                    j++;
                }
                message += huf.message[k-1];
            }
            label2.Text = message;
        }
    }

    public class Huffman
    {
        public string[] message;
        public int LenOfMess;
        public double[] Prob;
        public Node[] tree;
        //public static string[] characters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public Huffman(string mess, int len, string prob)
        {
            this.LenOfMess = len;
            this.message = SplitMessage(mess);
            this.Prob = Init_Prob(prob);/*Call function Init_Prob, Prob has been sorted, from max to min*/
            this.tree = Init_tree();
        }

        /*Init the probability box*/
        public double[] Init_Prob(string prob)
        {
            string[] Probs = prob.Split(new char[] { ' ' });/*convert string to string[]*/
            double[] Probability = new double[this.LenOfMess];/*Create an array*/
            for(int i = 0; i < this.LenOfMess; i++)/*string to array*/
            {
                Probability[i] = Convert.ToDouble(Probs[i]);
            }
            /*Sort the probability*/
            
            return Bubblesort(Probability, this.message);
        }

        public Node[] Init_tree()
        {
            Node[] tree = new Node[2 * this.LenOfMess];
            for (int i = 1; i < 2 * this.LenOfMess; i++)
            {
                tree[i] = new Node();
            }
            tree = this.Encoder();
            return tree;
        }
        public string[] SplitMessage(string message)
        {
            string mess = message;
            string[] signal = new string[this.LenOfMess];
            for(int i = 0; i < this.LenOfMess; i++)     /*split the message into single word*/
            {
                signal[i] = mess.Substring(i, 1);
            }

            return signal; /*return a string array*/
        }

        /* swap double array */
        public void swap(double[] arr, int i, int j)
        {
            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /* swap string array*/
        public void swap(string[] arr, int i, int j)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /* ENcoder of huffman*/
        public Node[] Encoder()
        {
            int m = 2 * this.LenOfMess - 1;
            Node[] prob = new Node[m+1];

            for(int i = 1; i < m + 1; i++)
            {
                prob[i] = new Node();
            }
            /* Init the node array*/
            for(int i = 1; i < this.LenOfMess+1; i++)
            {
                prob[i].prob = this.Prob[i-1];
                prob[i].parent = 0;
                prob[i].leftchild = 0;
                prob[i].rightchild = 0;
            }

            /* Build the huffman tree */ 
            for(int i = this.LenOfMess+1; i < m+1; i++)
            {
                int[] location = select(prob, i - 1);
                prob[location[0]].parent = i;
                prob[location[1]].parent = i;
              
                prob[i].leftchild = location[0];
                prob[i].rightchild = location[1];                            
                prob[i].prob = prob[location[0]].prob + prob[location[1]].prob; 
            }

            return prob;
        }

        public string[] CodeList()
        {
            string[] Code = new string[this.LenOfMess];
            for(int i = 1; i < this.LenOfMess + 1; i++)
            {
                string subcode = "";
                int[] visit = new int[2 * this.LenOfMess];
                Code[i-1] = Findmess(this.tree, i, 2*this.LenOfMess-1, subcode, visit);
            }
            return Code;
        }

        public string Findmess(Node[] tree, int index, int start, string code, int[] visit)
        {
            
            int left = tree[start].leftchild;
            int right = tree[start].rightchild;

            if(check(visit, start, left, right) == 0)
            {
                return code;
            }
            visit[start] = 1;
            /* find the solution*/
            if (left == 0 && right ==0 && tree[start].prob == tree[index].prob)
            {
                visit[0] = -1;
                return code;
            }

            if (visit[index] != 1 && left != 0)
            {
                code = Findmess(tree, index, left, code + "0", visit);
                /* use visit[0](never used during the program) to represent the target has been found*/
                if(visit[0] == 0)
                {
                    code = code.Remove(code.Length - 1); /* delete the useless track*/
                }
            }
            
            if(visit[index] != 1 && right != 0)
            {
               
                code = Findmess(tree, index, right, code + "1", visit);
                /* use visit[0](never used during the program) to represent the target has been found*/
                if (visit[0]  == 0)
                {
                    code = code.Remove(code.Length - 1); /* delete the useless track*/
                }

            }
            
           

            return code;

            
        }

        /* validation */
        public int check(int[] visit, int loc, int left, int right)
        {
            if(visit[loc] == 0)
            {
                return 1;
            }
            return 0;
        }

        public double[] Bubblesort(double[] arr, string[] str)
        {
            for (int i = 0; i < this.LenOfMess - 1; i++)
            {
                for (int j = 0; j < this.LenOfMess - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                        swap(str, j, j + 1);
                    }
                }
            }
            return arr;
        }

        public int[] select(Node[] arr, int len)
        {
            int[] location = new int[2];
            double min1 = 200, min2 = 200; /*randomly choose a max number*/

            for(int i = 1; i < len+1; i++)
            {
                if(arr[i].prob < min1 && arr[i].parent == 0)
                {
                    min1 = arr[i].prob;
                    location[0] = i;
                }
             
            }

            double temp = arr[location[0]].prob;
            arr[location[0]].prob = 200;

            for (int i = 1; i < len + 1; i++)
            {
                if (arr[i].prob < min2 && arr[i].parent == 0)
                {
                    min2 = arr[i].prob;
                    location[1] = i;
                }

            }

            arr[location[0]].prob = temp;

            return location;
        }
    }

    public class Node
    {
        public int parent;
        public int leftchild;
        public int rightchild;
        public double prob;

        public Node()
        {
            this.parent = 0;
            this.leftchild = 0;
            this.rightchild = 0;
            this.prob = 0;
        }
    }
}
