using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string strname = txtName.Text;
            string strename = txtEName.Text;
            string strsex = txtSex.Text;
            string strconstellation = txtConstellation.Text;

            MessageBox.Show("Hello,我是" + strname + "\n" + "英文名子是" + strename + "\n" + "性別是" + strsex + "\n" + "星座是" + strconstellation + "\n" + "很高興認識您!");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string strname = txtName.Text;
            string strename = txtEName.Text;
            string strsex = txtSex.Text;
            string strconstellation = txtConstellation.Text;

            MessageBox.Show("Hi,我是" + strname + "\n" + "英文名子是" + strename + "\n" + "性別是" + strsex + "\n" + "星座是" + strconstellation + "\n" + "很高興認識您!");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
