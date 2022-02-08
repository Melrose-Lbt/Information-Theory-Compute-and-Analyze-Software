using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class Subpage2 : Form
    {
        public Subpage2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemFigure2 f = new SystemFigure2();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinearCoding f = new LinearCoding();
            f.Show();
            this.Close();
        }

        private void DisEntropy_Click(object sender, EventArgs e)
        {
            HammingCoding f = new HammingCoding();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecurrentCoding f = new RecurrentCoding();
            f.Show();
            this.Close();
        }
    }
}
