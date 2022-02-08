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
        public string[] Elem;
        public int[] code;
        public Encoder_Decoder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EDcoderHome f1 = new EDcoderHome();
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
            label2.Text = "";
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

        private void LZ_Encoder_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label14.Text = "";
            LZ lz = new LZ(textBox1.Text, textBox1.Lines[0].Length);
            string p, s, ps;
            string[] signal = new string[EncodeBox.Lines[0].Length];


            for (int i = 0; i < EncodeBox.Lines[0].Length; i++)     /*split the message into single word*/
            {
                signal[i] = EncodeBox.Text.Substring(i, 1);
            }
            
            // Initialize the dict.
            p = "";
            s = signal[0];
            ps = p + s;
            if (lz.FindElem(ps) == 1)
            {
                p = s;
            }
            int l = 0;

            /* separate i and k, because if use i to control the whole process there will be a bug here */
            int m = lz.LenOf_singleElem - 1;
            for (int i = 1; i < EncodeBox.Lines[0].Length; i++)
            {
                s = signal[i];
                ps = p + s;
                if (lz.FindElem(ps) == 1)
                {
                    p = ps;
                    m--;
                    l--;
                }
                else
                {
                    lz.singleElem[m + 1] = ps;
                    lz.code[m + 1] = lz.code[m] + 1;
                    lz.code_output[l] = lz.FindElem_code(p);
                    p = s;
                }
                m++;
                l++;
            }
            // To make sure the last one be coded
            lz.code_output[l] = lz.FindElem_code(p);


            int k = 0;
            while (lz.singleElem[k] != "") 
            {
                
                label10.Text += lz.singleElem[k] + ":" + lz.code[k] + " ";
                //label14.Text += lz.code[k] + " ";
                if (k!=0 && k % 3 == 0)
                {
                    label10.Text += "\n";
                }
                k++;
                
            }

            //Print the code
            int code_index = 0;
            while(lz.code_output[code_index] != 0)
            {
                label14.Text += lz.code_output[code_index] + " ";
                code_index++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "";

            LZ lz = new LZ(textBox1.Text, textBox1.Lines[0].Length);

            this.Elem = lz.singleElem;
            this.code = lz.code;

            for (int i=0;i< textBox1.Lines[0].Length; i++)
            {
                label9.Text += lz.singleElem[i] + ":" + lz.code[i] + "\n";
            }
        }

        private void LZ_Decoder_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            string[] mess = DecodeBox.Text.Split(" ");
            string p, c, pc;
            int pw, cw;
            LZW_Decode Decoder = new LZW_Decode(textBox1.Text, textBox1.Lines[0].Length);


            //Initialize the dict
            pw = 0;
            cw = Convert.ToInt32(mess[0]);
            if(Decoder.ExistElem(cw) == 1)
            {
                Decoder.Elem_output[0] = Decoder.FindElem(cw);
            }
            pw = cw;
            int m = Decoder.LenOf_singleElem - 1;
            for(int i = 1; i < mess.Length; i++)
            {
                cw = Convert.ToInt32(mess[i]);
                if(Decoder.ExistElem(cw) == 1)
                {
                    Decoder.Elem_output[i] = Decoder.FindElem(cw);
                    p = Decoder.FindElem(pw);
                    c = Convert.ToString(Decoder.FindElem(cw)[0]);
                    pc = p + c;
                    Decoder.singleElem[m + 1] = pc;
                    Decoder.code[m + 1] = Decoder.code[m] + 1;
                    m++;
                }
                else
                {
                    p = Decoder.FindElem(pw);
                    c = Convert.ToString(Decoder.FindElem(pw)[0]);
                    pc = p + c;
                    Decoder.singleElem[m + 1] = pc;
                    Decoder.code[m + 1] = Decoder.code[m] + 1;
                    Decoder.Elem_output[i] = pc;
                    m++;
                }
                pw = cw;
            }

            int index = 0;
            while (Decoder.Elem_output[index] != "")
            {
                label15.Text += Decoder.Elem_output[index];
                index++;
            }

        }
    }

    public class LZ
    {
        public string[] singleElem = new string[100];
        public int LenOf_singleElem;
        public int[] code = new int[100];
        public int[] code_output = new int[100];

        public LZ(string mess, int len)
        {
            this.LenOf_singleElem = len;
            this.singleElem = Elem_Init(mess);
            this.code = Code_Init();
            this.code_output = Output_Init();
        }

        public int[] Output_Init()
        {
            int[] code = new int[100];
            for (int i = 0; i < code.Length; i++)
            {
                    code[i] = 0;
            }
            return code;
        }

        public string[] Elem_Init(string message)
        {
            string mess = message;
            string[] signal = new string[100];
            for (int i = 0; i < code.Length; i++)     /*split the message into single word*/
            {
                if (i < this.LenOf_singleElem)
                {
                    signal[i] = mess.Substring(i, 1);
                }
                else
                {
                    signal[i] = "";
                }
            }

            return signal; /*return a string array*/
        }

        public int[] Code_Init()
        {
            int[] code = new int[100];
            int cnt = 1;
            for(int i = 0; i < code.Length; i++)
            {
                if (i < this.LenOf_singleElem)
                {
                    code[i] = cnt;
                    cnt++;
                }
                else
                {
                    code[i] = 0;
                }
                
            }
            return code;
        }

        /* To find whether elem in the list */ 
        public int FindElem(string elem)
        {
            for(int i = 0; i < this.singleElem.Length; i++)
            {
                if(elem == singleElem[i])
                {
                    return 1;
                }
            }
            return 0;
        }

        public int FindElem_code(string elem)
        {
            for (int i = 0; i < this.singleElem.Length; i++)
            {
                if (elem == singleElem[i])
                {
                    return i+1;
                }
            }
            return -1;
        }
    }

    public class LZW_Decode
    {
        public string[] singleElem = new string[100];
        public int LenOf_singleElem;
        public int[] code = new int[100];
        public string[] Elem_output = new string[100];

        public LZW_Decode(string mess, int len)
        {
            this.LenOf_singleElem = len;
            this.singleElem = Elem_Init(mess);
            this.code = Code_Init();
            this.Elem_output = Init_outputElem();
        }

        public string[] Init_outputElem()
        {
            string[] Elem_output = new string[100];
            for (int i = 0; i < Elem_output.Length; i++)
            {
                Elem_output[i] = "";
            }
            return Elem_output;
        }

        public string[] Elem_Init(string message)
        {
            string mess = message;
            string[] signal = new string[100];
            for (int i = 0; i < code.Length; i++)     /*split the message into single word*/
            {
                if (i < this.LenOf_singleElem)
                {
                    signal[i] = mess.Substring(i, 1);
                }
                else
                {
                    signal[i] = "";
                }
            }

            return signal; /*return a string array*/
        }

        public int[] Code_Init()
        {
            int[] code = new int[100];
            int cnt = 1;
            for (int i = 0; i < code.Length; i++)
            {
                if (i < this.LenOf_singleElem)
                {
                    code[i] = cnt;
                    cnt++;
                }
                else
                {
                    code[i] = 0;
                }

            }
            return code;
        }

        public string FindElem(int index)
        {
            for(int i = 0; i < this.code.Length; i++)
            {
                if(index == this.code[i])
                {
                    return this.singleElem[i];
                }
            }
            return "";
        }

        public int ExistElem(int index)
        {
            for (int i = 0; i < this.code.Length; i++)
            {
                if (index == this.code[i])
                {
                    return 1;
                }
            }
            return 0;
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
