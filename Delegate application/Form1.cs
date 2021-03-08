using Delegate_application.engines;
using Delegate_application.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_application
{
    public partial class Form1 : Form
    {
        myDel DelegateTest;

        public Form1()
        {
            InitializeComponent();
        }

        int number1 = 0;
        int number2 = 0;

        public bool SetNumbers()
        {
            string s1 = txtbox1.Text;
            string s2 = txtbox2.Text;

            if (VerifyIfNumber.Veryfication(s1, s2) == true)
            {
                number1 = int.Parse(s1);
                number2 = int.Parse(s2);
                return true;
            }
            else
            {
                MessageBox.Show("Podano nieprawidłowe liczby");
                ClearingFields();
                return false;
            }
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            ClearingFields();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            if (SetNumbers() == true)
            {
                DelegateTest = add.ADD;
                txtbox3.Text = (DelegateTest(number1, number2)).ToString();
            }
        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            if (SetNumbers() == true)
            {
                DelegateTest = sub.SUB;
                txtbox3.Text = (DelegateTest(number1, number2)).ToString();
            }
        }

        private void tbnMUL_Click(object sender, EventArgs e)
        {
            if (SetNumbers() == true)
            {
                DelegateTest = mul.MUL;
                txtbox3.Text = (DelegateTest(number1, number2)).ToString();
            }
        }

        private void btnDIV_Click(object sender, EventArgs e)
        {
            if (SetNumbers() == true)
            {
                if (number2 != 0)
                {
                    DelegateTest = div.DIV;
                    txtbox3.Text = (DelegateTest(number1, number2)).ToString();
                }
            }
        }

        private void ClearingFields()
        {
            txtbox1.Clear();
            txtbox2.Clear();
            txtbox3.Clear();

            number1 = 0;
            number2 = 0;
        }
    }
}
