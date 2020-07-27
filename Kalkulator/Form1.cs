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

        const string divideByZero = "Error";
        const string syntaxErr = "SYNTAX ERROR!";

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
            btnMinus.Enabled = enable;
        }

        private void PreCheck_ButtonClick()
        {
            if (textBox1.Text == divideByZero)
            {
                textBox1.Clear();
            }

            if (previousOperation != Operation.None)
            {
                EnableOperatorButtons();
            }

        }

        private void PerformCalculation(Operation previousOperation)
        {
            try
            {
                if (previousOperation == Operation.None)
                    return;
                List<double> lstNums = null;

                switch (previousOperation)
                {
                    case Operation.Add:
                        {
                            if (currentOperation == Operation.Sub)
                            {
                                currentOperation = Operation.Add;
                            }
                            lstNums = textBox1.Text.Split('+').Select(double.Parse).ToList();
                            textBox1.Text = (lstNums[0] + lstNums[1]).ToString();
                            break;
                        }
                    case Operation.Sub:
                        {
                            int idx = textBox1.Text.LastIndexOf('-');
                            if (idx > 0)
                            {
                                var op1 = Convert.ToDouble(textBox1.Text.Substring(0, idx));
                                var op2 = Convert.ToDouble(textBox1.Text.Substring(idx + 1));
                                textBox1.Text = (op1 - op2).ToString();
                            }
                            break;
                        }
                    case Operation.Mul:
                        {
                            if (currentOperation == Operation.Sub)
                            {
                                currentOperation = Operation.Mul;
                                return;
                            }
                            lstNums = textBox1.Text.Split('*').Select(double.Parse).ToList();
                            textBox1.Text = (lstNums[0] * lstNums[1]).ToString();
                            break;
                        }
                    case Operation.Div:
                        {
                            if (currentOperation == Operation.Sub)
                            {
                                currentOperation = Operation.Div;
                                return;
                            }
                            try
                            {
                                lstNums = textBox1.Text.Split('/').Select(double.Parse).ToList();
                                if (lstNums[1] == 0)
                                {
                                    throw new DivideByZeroException();
                                }
                            }
                            catch (DivideByZeroException)
                            {
                                textBox1.Text = divideByZero;
                            }
                            break;
                        }
                    case Operation.None:
                    default:
                        break;
                }

            }
            catch (Exception)
            {
                textBox1.Text = syntaxErr;
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Add;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            textBox1.Text += (sender as Button).Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.None;

            EnableOperatorButtons();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || previousOperation == Operation.Sub) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Sub;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            textBox1.Text += (sender as Button).Text;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Mul;
            PerformCalculation(previousOperation);
            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            textBox1.Text += (sender as Button).Text;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Div;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            textBox1.Text += (sender as Button).Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            decimalPointActive = false;
            PreCheck_ButtonClick();
            previousOperation = Operation.None;
            textBox1.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
    }
}
