using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationTheoryExp_1
{
    public partial class HelloFrm : Form
    {
        public HelloFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (UsrName.Text.Length<=0)
            {
                UsrName.Text = "请输入用户名";
            }
            if (Usrcode.Text.Length<=0)
            {
                Usrcode.Text = "请输入密码";
            }
            if(Usrcode.Text != "2001121")
            {
                Usrcode.Text = "密码不正确！";
            }
            if(UsrName.Text == "Shannon" && Usrcode.Text == "2001121")
            {
                DashBoard  f = new DashBoard();
                f.Show();
                this.Close();
            }
        }
    }
}
