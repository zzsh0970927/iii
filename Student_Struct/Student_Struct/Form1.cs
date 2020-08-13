using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Struct
{
    public partial class Form1 : Form
    {
        string studentName;
        double Chinese;
        double English;
        double Mathematics;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentName = txtName.Text;
            Chinese = Convert.ToDouble(txtChi.Text);
            English = Convert.ToDouble(txtEng.Text);
            Mathematics = Convert.ToDouble(txtMath.Text);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtGrade.Text = $"姓名:{studentName}\r\n國文:{Chinese}\r\n英文:{English}" +
                $"\r\n數學:{Mathematics}";
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            double Maxresult;
            double Minresult;

            Maxresult = Math.Max(Mathematics, English);            
            Maxresult = Math.Max(Maxresult, Chinese);
            txtMaxMin.Text = Maxresult.ToString();

            Minresult = Math.Min(Mathematics, English);
            Minresult = Math.Min(Minresult, Chinese);
            txtMaxMin.Text +="\r\n" + Minresult.ToString();

            

        }
    }
}
