using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        bool decimalPointActive = false;

        Operation previousOperation = Operation.None;
        Operation currentOperation = Operation.None;

        public string tempText;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void EnableOperatorButtons(bool enable = true)
        {
            btnMultiplication.Enabled = enable;
            btnDivision.Enabled = enable;
            btnPlus.Enabled = enable;
            if (!enable)
            {
                decimalPointActive = false;
            }
            //btnSub.Enabled = enable;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tempText = tempText + "1";
            textBox1.Text += "1";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
