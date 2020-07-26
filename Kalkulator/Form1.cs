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

        public string tempText;

        List<int> numbersList = new List<int>();

        List<char> charsList = new List<char>();

        int numberConnecting = 0;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tempText = tempText + "1";
            textBox1.Text += "1";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

            numbersList.Add(int.Parse(tempText));

            tempText = "";

            charsList.Add('+');
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (numbersList.Count >= 2 && charsList.Count >= 1)
            {
                int numberOfPlus = 0;
                int numberOfMinus = 0;
                int numberOfMultiplication = 0;
                int numberOfDivision = 0;

                List<int> listPlus = new List<int>();
                List<int> listMinus = new List<int>();
                List<int> listMultiplication = new List<int>();
                List<int> listDivision = new List<int>();

                //Dzielenie

                for (int i = 0; i < charsList.Count; i++)
                {
                    if (charsList[i] == '/')
                    {
                        numberOfDivision++;
                        listDivision.Add(i);
                    }
                }

                //////////////////////////////////////////////////

                for (int i = 0; i < listDivision.Count; i++)
                {
                    numbersList[listDivision[i]] = numbersList[listDivision[i]] / numbersList[listDivision[i] + 1];
                    numbersList.RemoveAt(numbersList[listDivision[i] + 1]);

                    charsList.RemoveAt(listDivision[i]);
                }

                //Mnożenie

                for (int i = 0; i < charsList.Count; i++)
                {
                    if (charsList[i] == '*')
                    {
                        numberOfMultiplication++;
                        listMultiplication.Add(i);
                    }
                }

                for (int i = 0; i < listMultiplication.Count; i++)
                {
                    numbersList[listMultiplication[i]] = numbersList[listMultiplication[i]] * numbersList[listMultiplication[i] + 1];
                    numbersList.RemoveAt(numbersList[listMultiplication[i] + 1]);

                    charsList.RemoveAt(listMultiplication[i]);
                }

                //Odejmowanie

                for (int i = 0; i < charsList.Count; i++)
                {
                    if (charsList[i] == '-')
                    {
                        numberOfMinus++;
                        listMinus.Add(i);
                    }
                }

                for (int i = 0; i < listMultiplication.Count; i++)
                {
                    numbersList[listMinus[i]] = numbersList[listMinus[i]] * numbersList[listMinus[i] + 1];
                    numbersList.RemoveAt(numbersList[listMinus[i] + 1]);

                    charsList.RemoveAt(listMinus[i]);
                }

                if (charsList.Count == 0)
                {
                    int temp = numbersList[0];
                    textBox1.Text = temp.ToString();
                }
                else
                //Końcowe dodawanie
                {
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        numberConnecting += numbersList[i];
                    }
                    textBox1.Text = numberConnecting.ToString();
                }

            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";

            numbersList.Add(int.Parse(tempText));

            tempText = "";

            charsList.Add('-');
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";

            numbersList.Add(int.Parse(tempText));

            tempText = "";

            charsList.Add('*');
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

            numbersList.Add(int.Parse(tempText));

            tempText = "";

            charsList.Add('/');
        }
    }
}
