using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class EDcoderHome : Form
    {
        public EDcoderHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SystemFigure f1 = new SystemFigure();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encoder_Decoder f = new Encoder_Decoder();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kraft f = new Kraft();
            f.Show();
            this.Close();
        }
    }
}
