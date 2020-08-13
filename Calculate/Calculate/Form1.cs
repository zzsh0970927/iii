using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(txtX.Text);
                double Y = Convert.ToDouble(txtY.Text);

                txtAns.Text = (X + Y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確數值!");

            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(txtX.Text);
                double Y = Convert.ToDouble(txtY.Text);

                txtAns.Text = (X - Y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確數值!");

            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(txtX.Text);
                double Y = Convert.ToDouble(txtY.Text);

                txtAns.Text = (X * Y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確數值!");

            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(txtX.Text);
                double Y = Convert.ToDouble(txtY.Text);

                txtAns.Text = (X / Y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確數值!");

            }
        }
    }
}



