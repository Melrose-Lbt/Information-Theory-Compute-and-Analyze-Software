using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Entropy_Click(object sender, EventArgs e)
        {
            SystemFigure f = new SystemFigure();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemFigure2 f = new SystemFigure2();
            f.Show();
            this.Close();
        }
    }
}
