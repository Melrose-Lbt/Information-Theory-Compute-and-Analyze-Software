using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class SystemFigure : Form
    {
        public SystemFigure()
        {
            InitializeComponent();
        }
        private void SystemFigure_Load(object sender, EventArgs e)
        {

        }

        private void Entropy_Click(object sender, EventArgs e)
        {
            SignalEntropy f3 = new SignalEntropy();
            f3.Show();
            this.Close();
        }

        private void DisEntropy_Click(object sender, EventArgs e)
        {
            DisSequenceEntropy f4 = new DisSequenceEntropy();
            f4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EDcoderHome f5 = new EDcoderHome();
            f5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard f = new DashBoard();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Markov f = new Markov();
            f.Show();
            this.Close();
        }
    }
}
