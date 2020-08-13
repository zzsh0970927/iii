using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class Frm_StartGuess : Form
    {
        public Frm_StartGuess()
        {
            InitializeComponent();
        }

        int guess, min, max;

        private void Frm_StartGuess_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 100);
            min = 0;
            max = 100;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int myguess = 0;

            try
            {
                myguess = int.Parse(txtInput.Text);
            }

            catch 
            {
                MessageBox.Show("請輸入數字!");
            }

            if (myguess >= 1 && myguess < 100) 
            {
            
            if (myguess == guess)
            {
                MessageBox.Show("答對了!!正確答案是:" + guess);
            }

            else if (myguess > guess)
            {
                    MessageBox.Show("再小一點點...");
                    //Form1 main = new Form1();
                    //lblTitle.Text = $"Too Large\r\nBetween 0 and {myguess},";
                }

            else if (myguess < guess)
            {
                MessageBox.Show("再大一點點...");
            }

            }

            else 
            {
                MessageBox.Show("請輸入提示範圍內的數字");
            }
        }
    }
}
