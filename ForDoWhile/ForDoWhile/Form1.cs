using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOodEven_Click(object sender, EventArgs e)
        {            
            try
            {
                int Number;
                Number = int.Parse(txtNumber.Text);

                if (Number % 2 == 0)
                {
                    lblAns.Text = $"輸入的數 {Number}是偶數";
                }

                else
                {
                    lblAns.Text = $"輸入的數 {Number}是奇數";
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("請輸入正確數值!");
            }
            
        }

        private void btnArrOddEven_Click(object sender, EventArgs e)
        {
            int even = 0;
            int odd = 0;
           

            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            foreach (int item in arr0711) 
            {
               
                if (item % 2 == 0)
                {
                    even++;
                }
                else 
                {
                    odd++;
                }                
            }    
            
            lblAns.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n奇數共{odd}\r\n偶數共{even}";
        }

        private void btnLongestName_Click(object sender, EventArgs e)
        {
            string[] arr0711_str = { "mother張", "emma", "迪克蕭", "J40","Candy","Cindy","Coconut","Motherfacker" };
            //lblAns.Text = arr0711_str[7].ToString();
            //未完成================================================
            int count = 0;

            foreach (string i in arr0711_str)
            {
                foreach (char x in i)
                {
                    if (x == 'C' || x == 'c')
                    {
                        count++;
                        break;
                    }

                }

            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };

            int intMax = arr0711[0];
            int intMin = arr0711[0];

            for (int i = 0; i < arr0711.Length; i++) 
            {
                if (intMax < arr0711[i]) 
                {
                    intMax = arr0711[i];
                }
                if (intMin > arr0711[i])
                {
                    intMin = arr0711[i];
                }

            }
            lblAns.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最大值為:{intMax}\r\n最小值為:{intMin}";

        }

        private void btnCorc_Click(object sender, EventArgs e)
        {
            string[] arr0711_str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = 0 ;
            
            foreach(string i in arr0711_str)
            {
                foreach(char x in i)
                {
                    if (x == 'C'|| x =='c')
                    {
                        count++;
                        break;
                    }
                    
                }
                
            }
            lblAns.Text = $"int陣列arr0711_str: mother張  emma  迪克蕭  J40   Candy  Cindy  Coconut   Motherfacker \r\n有C或c的名子有{count}位 ";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAns.Text = "結果";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int Num1 = 100, Num2 = 200;
            lblAns.Text = "換位前:" + ($"Num1={Num1} , Num2={Num2}");
            Swap(ref Num1, ref Num2);
            lblAns.Text += "\r\n" + "換位後:" + ($"Num1={Num1} , Num2={Num2}");
        }

        void Swap(ref int n1, ref int n2)
        {
            int T = n1;
            n1 = n2;
            n2 = T;
        }

        private void btnArrSum_Click(object sender, EventArgs e)
        {
            int result = 0;

            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            foreach (int i in arr0711)
            {
                result += i;
            }
            lblAns.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]" + "\r\n" + "加總為:" + result;
        }

        private void btnArrMax_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };

            int intMax = arr0711[0];            

            for (int i = 0; i < arr0711.Length; i++)
            {
                if (intMax < arr0711[i])
                {
                    intMax = arr0711[i];
                }                
            }
            lblAns.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最大值為:{intMax}";
        }

        private void btnArrMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            
            int intMin = arr0711[0];

            for (int i = 0; i < arr0711.Length; i++)
            {
                
                if (intMin > arr0711[i])
                {
                    intMin = arr0711[i];
                }

            }
            lblAns.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最小值為:{intMin}";
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            lblAns.Text = "九九乘法表" + "\r\n";

            int i,j;

            for ( i = 1 ; i < 10; i++)
            {
                           
                for ( j = 2; j < 10; j++)
                {
                    
                    lblAns.Text += string.Format("{0,10:C}", j + "*" + i + "=" + i * j+ "|");
                }
                lblAns.Text += "\r\n";
            }
            
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtFrom.Text);
            int j = int.Parse(txtTo.Text);
            int s = int.Parse(txtStep.Text);

            
            int sum = 0;
            for (i = int.Parse(txtFrom.Text); i <= int.Parse(txtTo.Text); i += int.Parse(txtStep.Text)) 
            {
                sum += i;            
            }
            lblAns.Text = $"{txtFrom.Text}到{txtTo.Text}相隔{txtStep.Text}\r\n加總為{+sum}";
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtFrom.Text);
            int j = int.Parse(txtTo.Text);
            int s = int.Parse(txtStep.Text);
            int sum = 0;
            while (i <= j)
            {
                sum += i;
                i+=s;
               
            }
            lblAns.Text = $"{txtFrom.Text}到{txtTo.Text}相隔{txtStep.Text}\r\n加總為{+sum}";

        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtFrom.Text);
            int j = int.Parse(txtTo.Text);
            int s = int.Parse(txtStep.Text);
            int sum = 0;
            do
            {
                sum += i;
                i += s;

            } while (i <= j);
            lblAns.Text = $"{txtFrom.Text}到{txtTo.Text}相隔{txtStep.Text}\r\n加總為{+sum}";
        }

        private void btnRows_Click(object sender, EventArgs e)
        {
            
            int r;
            r = int.Parse(txtRows.Text);
            

            string t = "";
            for (int i = 0; i < r; i++)
            {
                string l = "";
                for (int j = 0; j <= i; j++)
                {
                    l += "*";
                }
                t +=l +"\r\n";
            }
            lblAns.Text = t;




        }
    }
}
