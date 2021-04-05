using Liczenie_makroskładników.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liczenie_makroskładników
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtBoxB_TextChanged(object sender, EventArgs e)
        {
            string text = txtBoxB.Text;

            if(text.Length != 0)
            {
                char c = text[text.Length - 1];

                string tempText = text.Remove(text.Length - 1);

                var returnedModel = CheckIfStringIsCorrect.CheckIfStringIsCorrectMethod(tempText,c);

                txtBoxB.Text = returnedModel.Text;
            }
        }
    }
}
