using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liczenie_makroskładników
{
    public partial class Form3 : Form
    {
        int generalAmount = 0;

        public Form3()
        {
            InitializeComponent();
        }

        public void AmountRefresh()
        {
            textBox1.Text = generalAmount.ToString();
        }

        public bool CheckIfAmountWillBeNotNegative(int a,int n)
        {
            if(a - n >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckIfAmountEqualsZero()
        {
            if(generalAmount == 0)
            {
                btn1.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
            }
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            generalAmount++;
            AmountRefresh();
            CheckIfAmountEqualsZero();
        }

        private void btnP5_Click(object sender, EventArgs e)
        {
            generalAmount += 5;
            AmountRefresh();
            CheckIfAmountEqualsZero();
        }

        private void btnP25_Click(object sender, EventArgs e)
        {
            generalAmount += 25;
            AmountRefresh();
            CheckIfAmountEqualsZero();
        }

        private void btnP100_Click(object sender, EventArgs e)
        {
            generalAmount += 100;
            AmountRefresh();
            CheckIfAmountEqualsZero();
        }

        private void btnM100_Click(object sender, EventArgs e)
        {
            if(CheckIfAmountWillBeNotNegative(generalAmount,100) == true)
            {
                generalAmount -= 100;
                AmountRefresh();
                CheckIfAmountEqualsZero();
            }
        }

        private void btnM25_Click(object sender, EventArgs e)
        {
            if (CheckIfAmountWillBeNotNegative(generalAmount, 25) == true)
            {
                generalAmount -= 25;
                AmountRefresh();
                CheckIfAmountEqualsZero();
            }
        }

        private void btnM5_Click(object sender, EventArgs e)
        {
            if (CheckIfAmountWillBeNotNegative(generalAmount, 5) == true)
            {
                generalAmount -= 5;
                AmountRefresh();
                CheckIfAmountEqualsZero();
            }
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            if (CheckIfAmountWillBeNotNegative(generalAmount, 1) == true)
            {
                generalAmount -= 1;
                AmountRefresh();
                CheckIfAmountEqualsZero();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ilosc.txt", generalAmount.ToString());
            this.Close();
        }
    }
}
