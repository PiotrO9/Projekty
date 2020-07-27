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
        private readonly List<Item> _calculactionNameList = new List<Item>();

        private readonly FillingCalculationList _fillingCalculationList;

        public Form1()
        {
            InitializeComponent();
            this._fillingCalculationList = new FillingCalculationList(_calculactionNameList);
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddOperation(OperationType.Plus);
            UpdateUserMessage();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddOperation(OperationType.Minus);
            UpdateUserMessage();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddOperation(OperationType.Multiplication);
            UpdateUserMessage();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddOperation(OperationType.Divide);
            UpdateUserMessage();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.Clear();
            UpdateUserMessage();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(1);
            UpdateUserMessage();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(2);
            UpdateUserMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(3);
            UpdateUserMessage();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(4);
            UpdateUserMessage();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(5);
            UpdateUserMessage();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(6);
            UpdateUserMessage();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(7);
            UpdateUserMessage();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(8);
            UpdateUserMessage();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(9);
            UpdateUserMessage();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this._fillingCalculationList.AddNumber(0);
            UpdateUserMessage();
        }
        private void UpdateUserMessage()
        {
            Display.Text = this._fillingCalculationList.GetUserTextBox();
        }
    }
}
