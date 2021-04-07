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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<TextBox> listOfTextBoxes = new List<TextBox>();

            listOfTextBoxes.Add(txtBoxB);
            listOfTextBoxes.Add(txtBoxT);
            listOfTextBoxes.Add(txtBoxW);

            bool[] arrayOFStatements = new bool[3];

            int i = 0;

            foreach (var txtBox in listOfTextBoxes)
            {
                    if (txtBox.Text == string.Empty)
                    {
                        arrayOFStatements[i] = false;
                    }
                    else if(float.TryParse(txtBox.Text,out float result) == false)
                    {
                        arrayOFStatements[i] = false;
                    }
                    else
                    {
                        arrayOFStatements[i] = true;
                    }
                i++;
            }

            bool resultOfCheck = CheckIfAllStatementsAreTrue.CheckIfAllStatementsAreTrueMethod(arrayOFStatements);

            if(resultOfCheck == true && txtBoxName.Text != string.Empty)
            {
                // Kod dodania produktu

                string[] datasToConvert = new string[6];

                datasToConvert[0] = txtBoxName.Text;
                datasToConvert[1] = txtBoxB.Text;
                datasToConvert[2] = txtBoxT.Text;
                datasToConvert[3] = txtBoxW.Text;
                datasToConvert[4] = txtBoxKcal.Text;

                if(txtBoxBarCode.Text == string.Empty)
                {
                    datasToConvert[5] = "0";
                }
                else 
                {
                    datasToConvert[5] = txtBoxBarCode.Text;
                }

                AddProduct.AddProductMethod(datasToConvert);
                
            }
            else
            {
                MessageBox.Show("Wprowadzono nieprawidłowe dane");
            }

        }

        private void txtBoxB_TextChanged(object sender, EventArgs e)
        {
            UpdateKcal();
        }

        private void txtBoxT_TextChanged(object sender, EventArgs e)
        {
            UpdateKcal();
        }

        private void txtBoxW_TextChanged(object sender, EventArgs e)
        {
            UpdateKcal();
        }

        private void UpdateKcal()
        {
            float B;
            bool Bbool = float.TryParse(txtBoxB.Text,out B);

            float T;
            bool Tbool = float.TryParse(txtBoxT.Text, out T);

            float W;
            bool Wbool = float.TryParse(txtBoxW.Text, out W);

            float kcal = (B * 4) + (T*9) + (W*4);

            txtBoxKcal.Text = kcal.ToString();
        }
    }
}
