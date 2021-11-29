using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class SignalEntropy : Form
    {
        public SignalEntropy()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SystemFigure f1 = new SystemFigure();
            f1.Show();
            this.Close();
        }

        private void CalI_Click(object sender, EventArgs e)
        {
            double px, y;
            px = Convert.ToDouble(textBox1.Text);
            y = -Math.Log(px, 2);
            y = Math.Round(y, 2);
            label3.Text = Convert.ToString(y) + "bit";
        }

        private void EntropyCal_Click(object sender, EventArgs e)
        {
            string[] arr = new string[textBox2.Lines.Length];
            double[] px = new double[textBox2.Lines.Length];
            double[] y = new double[textBox2.Lines.Length];
            double sum = 0,sump = 0;
            for(int i = 0; i < textBox2.Lines.Length; i++)
            {
                arr[i] = textBox2.Lines[i];
                px[i] = Convert.ToDouble(arr[i]);
                y[i] = -px[i] * Math.Log(px[i], 2);
                sum += y[i];
                sump += px[i];
            }
            sum = Math.Round(sum, 3);
            if (sump == 1)
            {
                SrcEntropy.Text = "信源熵：";
                label4.Text = Convert.ToString(sum) + "bit/sig";
            }
            else
            {
                SrcEntropy.Text = "信源概率不符合完备性！";
            }
            
        }
    }
}
