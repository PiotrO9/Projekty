using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_word_fruequency
{
    public partial class Form2 : Form
    {
        public TextBox textBoxForm1;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Nie podano wyrazu");
                return;
            }

            var listOfWords = (textBoxForm1.Text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '\r', '\n' },
                                                                StringSplitOptions.RemoveEmptyEntries)
                                                        ).ToList();

            int counting = 0;

            foreach (var word in listOfWords)
            {
                if (String.Equals(word, textBox1.Text, StringComparison.OrdinalIgnoreCase))
                    counting++;
            }

            if (counting == 0)
            {
                lbl1.Text = "Podanego słowa nie ma w tekście";
                return;
            }

            var listOfNumbers = new List<int>();

            for (int i = 0; i < listOfWords.Count; i++)
            {
                listOfNumbers.Add(1);
            }

            for (int i = 0; i < listOfWords.Count; i++)
            {
                for (int j = 0; j < listOfWords.Count; j++)
                {
                    if (listOfWords[i] == listOfWords[j] && i != j)
                    {
                        listOfNumbers[i]++;
                    }
                }
            }

            for (int i = 0; i < listOfWords.Count; i++)
            {
                for (int j = 0; j < listOfWords.Count; j++)
                {
                    if (listOfWords[i] == listOfWords[j] && i != j)
                    {
                        listOfWords.RemoveAt(j);
                        listOfNumbers.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < listOfWords.Count - 1; i++)
            {
                if (listOfWords[i] == listOfWords[i + 1] && listOfNumbers[i] == listOfNumbers[i + 1])
                {
                    listOfWords.RemoveAt(i + 1);
                    listOfNumbers.RemoveAt(i + 1);
                }
            }

            ListPrint.DataSource = listOfWords;
            listPrintOfNumbers.DataSource = listOfNumbers;

            lbl1.Text = "Podane słowo wystąpiło: " + "\n" + counting + " raz w tekście";

        }

        private void ListPrint_SizeChanged(object sender, EventArgs e)
        {
            ;
        }
    }
}
