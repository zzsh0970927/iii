using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countBeer = 0;
        int countTequila = 0;
        int countWhiskey = 0;
        int countWine = 0;

        int Beer = 40;
        int Tequila = 870;
        int Whiskey = 500;
        int Wine = 1000;

        string resultBeer;
        string resultTequila;
        string resultWhiskey;
        string resulttWine;

        string listBeer;
        string listTequila;
        string listWhiskey;
        string listWine;

        private void btnBeer_Click(object sender, EventArgs e)
        {

            countBeer++;
            txtTotalPrice.Text = "NT:" + (Beer * countBeer + Tequila * countTequila + Whiskey * countWhiskey + Wine * countWine) + "元";
            resultBeer = (Beer * countBeer).ToString();
            resultTequila = (Tequila * countTequila).ToString();
            resultWhiskey = (Whiskey * countWhiskey).ToString();
            resulttWine = (Wine * countWine).ToString();
            
            string result = "";
            listBeer = $"啤酒x{countBeer}總價:{resultBeer}" + "\r\n";
            listTequila = $"舌蘭酒x{countTequila}總價:{resultTequila}" + "\r\n";
            listWhiskey = $"威士忌x{countWhiskey}總價:{resultWhiskey}" + "\r\n";
            listWine = $"紅酒x{countWine}總價:{resulttWine}" + "\r\n";

            if (countBeer > 0)
            {
                result += listBeer;
            }
            if (countTequila > 0)
            {
                result += listTequila;
            }
            if (countWhiskey > 0)
            {
                result += listWhiskey;
            }
            if (countWine > 0)
            {
                result += listWine;
            }
            txtList.Text = result;
            


        }

        private void btnTequila_Click(object sender, EventArgs e)
        {        
            countTequila ++;           
            txtTotalPrice.Text = "NT:" + (Beer * countBeer + Tequila * countTequila + Whiskey * countWhiskey + Wine * countWine) + "元";
            resultBeer = (Beer * countBeer).ToString();
            resultTequila = (Tequila * countTequila).ToString();
            resultWhiskey = (Whiskey * countWhiskey).ToString();
            resulttWine = (Wine * countWine).ToString();
            
            string result = "";
            listBeer = $"啤酒x{countBeer}總價:{resultBeer}" + "\r\n";
            listTequila = $"舌蘭酒x{countTequila}總價:{resultTequila}" + "\r\n";
            listWhiskey = $"威士忌x{countWhiskey}總價:{resultWhiskey}" + "\r\n";
            listWine = $"紅酒x{countWine}總價:{resulttWine}" + "\r\n";

            if (countBeer > 0)
            {
                result += listBeer;
            }
            if (countTequila > 0)
            {
                result += listTequila;
            }
            if (countWhiskey > 0)
            {
                result += listWhiskey;
            }
            if (countWine > 0)
            {
                result += listWine;
            }
            txtList.Text = result;
            
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            countWhiskey++;
            txtTotalPrice.Text = "NT:" + (Beer * countBeer + Tequila * countTequila + Whiskey * countWhiskey + Wine * countWine) + "元";
            resultBeer = (Beer * countBeer).ToString();
            resultTequila = (Tequila * countTequila).ToString();
            resultWhiskey = (Whiskey * countWhiskey).ToString();
            resulttWine = (Wine * countWine).ToString();
            
            string result = "";
            listBeer = $"啤酒x{countBeer}總價:{resultBeer}" + "\r\n";
            listTequila = $"舌蘭酒x{countTequila}總價:{resultTequila}" + "\r\n";
            listWhiskey = $"威士忌x{countWhiskey}總價:{resultWhiskey}" + "\r\n";
            listWine = $"紅酒x{countWine}總價:{resulttWine}" + "\r\n";

            if (countBeer > 0)
            {
                result += listBeer;
            }
            if (countTequila > 0)
            {
                result += listTequila;
            }
            if (countWhiskey > 0)
            {
                result += listWhiskey;
            }
            if (countWine > 0)
            {
                result += listWine;
            }
            txtList.Text = result;
            
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            countWine++;
            txtTotalPrice.Text = "NT:" + (Beer * countBeer + Tequila * countTequila + Whiskey * countWhiskey + Wine * countWine) + "元";
            resultBeer = (Beer * countBeer).ToString();
            resultTequila = (Tequila * countTequila).ToString();
            resultWhiskey = (Whiskey * countWhiskey).ToString();
            resulttWine = (Wine * countWine).ToString();
            
            string result = "";
            listBeer = $"啤酒x{countBeer}總價:{resultBeer}"+"\r\n";
            listTequila = $"舌蘭酒x{countTequila}總價:{resultTequila}"+"\r\n";
            listWhiskey = $"威士忌x{countWhiskey}總價:{resultWhiskey}"+"\r\n";
            listWine = $"紅酒x{countWine}總價:{resulttWine}" + "\r\n";

            if (countBeer > 0)
            {
                result += listBeer;
            }
            if (countTequila > 0)
            {
                result += listTequila;
            }
            if (countWhiskey > 0)
            {
                result += listWhiskey;
            }
            if (countWine > 0)
            {
                result += listWine;
            }
            txtList.Text = result;
            
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            
            if (txtTotalPrice.Text == "")
            {
                MessageBox.Show("請輸入金額", "別鬧了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:" + (Beer * countBeer + Tequila * countTequila + Whiskey * countWhiskey + Wine * countWine).ToString());
            }
        }
            

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text == "")
            {
                MessageBox.Show("請輸入金額", "別鬧了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("折扣後金額:" + ((Beer * countBeer + Tequila * countTequila + Whiskey * countWhiskey + Wine * countWine) * 0.9).ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotalPrice.Clear();
            txtList.Clear();
            countBeer = 0;
            countTequila = 0;
            countWhiskey = 0;
            countWine = 0;
            txtList.Text = "尚未點餐";
        }
    }
}


