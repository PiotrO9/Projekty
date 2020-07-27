using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2
{
    public partial class Form1 : Form
    {
        int NumberOfPlus;
        int NumberOfMinus;
        int NumberOfMul;
        int NumberOfDiv;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            List<int> lstNums = null;

            int flagOfPlus = 0;
            int flagOfMinus = 0;
            int flagOfMul = 0;
            int flagOfDiv = 0;

            for (int i = 0; i < Display.Text.Length; i++)
            {
                if (Display.Text[i] == '+')
                {
                    flagOfPlus = 1;
                }
            }

            for (int i = 0; i < Display.Text.Length; i++)
            {
                if (Display.Text[i] == '-')
                {
                    flagOfMinus = 1;
                }
            }

            for (int i = 0; i < Display.Text.Length; i++)
            {
                if (Display.Text[i] == '*')
                {
                    flagOfMul = 1;
                }
            }

            for (int i = 0; i < Display.Text.Length; i++)
            {
                if (Display.Text[i] == '/')
                {
                    flagOfDiv = 1;
                }
            }

            if (flagOfPlus == 1)
            {
                lstNums = Display.Text.Split('+').Select(int.Parse).ToList();
                Display.Text = (lstNums[0] + lstNums[1]).ToString();
            }
            else if (flagOfMinus == 1)
            {
                lstNums = Display.Text.Split('-').Select(int.Parse).ToList();
                Display.Text = (lstNums[0] - lstNums[1]).ToString();
            }
            else if (flagOfMul == 1)
            {
                lstNums = Display.Text.Split('*').Select(int.Parse).ToList();
                Display.Text = (lstNums[0] * lstNums[1]).ToString();
            }
            else if (flagOfDiv == 1)
            {
                lstNums = Display.Text.Split('/').Select(int.Parse).ToList();

                if (lstNums[1] != 0)
                {
                    Display.Text = (lstNums[0] / lstNums[1]).ToString();
                }
                else
                {
                    Display.Text = "Dzielenie przez 0 niemożliwe";
                    Thread.Sleep(3000);
                    Display.Clear();
                }

            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            NumberOfPlus++;
            if (NumberOfPlus > 1 || NumberOfMinus >= 1 || NumberOfMul >= 1 || NumberOfDiv >= 1)
            {
                Calculate();
            }
            Display.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            NumberOfMinus++;
            if (NumberOfPlus >= 1 || NumberOfMinus > 1 || NumberOfMul >= 1 || NumberOfDiv >= 1)
            {
                Calculate();
            }
            Display.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            NumberOfMul++;
            if (NumberOfPlus >= 1 || NumberOfMinus >= 1 || NumberOfMul > 1 || NumberOfDiv >= 1)
            {
                Calculate();
            }
            Display.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            NumberOfDiv++;
            if (NumberOfPlus >= 1 || NumberOfMinus >= 1 || NumberOfMul >= 1 || NumberOfDiv > 1)
            {
                Calculate();
            }
            Display.Text += "/";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Display.Clear();
            NumberOfPlus = 0;
            NumberOfMinus = 0;
            NumberOfMul = 0;
            NumberOfDiv = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Display.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Display.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Display.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Display.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Display.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Display.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Display.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Display.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Display.Text += 0;
        }
    }
}
