using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrow
{
    public partial class Form1 : Form
    {        

        public Form1()
        {
            InitializeComponent();
        }

        double MoneyAmount;
        double MoneyYear;
        double MoneyRate;
        double MoneyHead;        
        double PayTotal;

        double MonthPayable;
        double MonthRate;
        double MonthPay;
        double LessHead;
        double MoneyBalance;

        private void btnMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("月付:" + (int)(PayTotal /(MoneyYear*12)));
           
        }        

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
            //double MoneyMonth = MoneyYear * 12;

            
            MessageBox.Show("總付款:" + (int)PayTotal);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MoneyAmount = Convert.ToDouble(txtAmount.Text);
            MoneyYear = Convert.ToDouble(txtYear.Text);
            MoneyRate = Convert.ToDouble(txtRate.Text);
            MoneyHead = Convert.ToDouble(txtHead.Text);

            LessHead = MoneyAmount - MoneyHead;

            MonthPayable = (LessHead / (MoneyYear * 12));

            for (double i = 0; i < MoneyYear * 12; i++)
            {

                MoneyBalance = (MoneyAmount -= MonthPay);
                MonthRate = (MoneyBalance) * ((MoneyRate / 100) / 12);
                MonthPay = MonthPayable + MonthRate;
                PayTotal += MonthPay;

            }

            

            Frm_Report fm = new Frm_Report();            
            fm.Show();
        }
    }
}
