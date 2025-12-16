using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppHello
{
    public partial class Homeworkarray03 : Form
    {
        public Homeworkarray03()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            BackColor = Color.FromArgb(rnd.Next(100, 256), rnd.Next(100, 256), rnd.Next(100, 256));

            int[][] MyArr = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };

            
            txbshow.Text = "";

            for (int i = 0; i < MyArr.Length; i++)
            {
                int sum = 0;
                string strLine = "";

                
                for (int j = 0; j < MyArr[i].Length; j++)
                {
                    strLine += MyArr[i][j] + "  ";
                    sum += MyArr[i][j];
                }

                

                txbshow.Text += strLine + Environment.NewLine;          
                txbshow.Text += "Sum = " + sum + Environment.NewLine;    
                txbshow.Text += "---end---" + Environment.NewLine;       
                txbshow.Text += Environment.NewLine;                     
            }
        }
    }
}
