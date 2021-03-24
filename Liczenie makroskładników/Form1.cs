using Liczenie_makroskładników.Engines;
using Liczenie_makroskładników.models;
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
    public partial class Form1 : Form
    {

        Product CurrentProduct;
        public int NumberOfClickedList = 0;

        public Form1()
        {
            InitializeComponent();
            SetSettingsInListViews();

            StreamWriter sw = new StreamWriter("wybor.txt");
            sw.Write("");
            sw.Close();

            File.WriteAllText("IsForm2Opened.txt", "closed"); //czyszczenie pliku IsForm2Opened.txt
            File.WriteAllText("ilosc.txt", "");  //czyszczenie pliku ilosc.txt
        }

        public void form2Opening()
        {
            Form2 form2 = new Form2();

           File.WriteAllText("IsForm2Opened.txt", "opened");

            form2.Show();
        }

        private void lblAdd1_Click(object sender, EventArgs e)
        {
            NumberOfClickedList = 1;
            lblAdd1.Enabled = false;
            form2Opening();
            timer1.Enabled = false;
        }

        private void lblAdd2_Click(object sender, EventArgs e)
        {
            NumberOfClickedList = 2;
            lblAdd2.Enabled = false;
            form2Opening();
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = File.ReadAllText("wybor.txt");

            if (s != string.Empty && NumberOfClickedList != 0 && CheckIfFileIsNotZero.CheckIfFileIsNotZeroFunction() == true)
            {
                CurrentProduct = ImportOneProduct.ImportSingleProduct(s);

                if (CheckIfFileIsEmpty.CheckIfEmpty(s) == false)
                {
                    Product product = CurrentProduct;

                    string[] arg = new string[7];

                    int amountOfGrams = int.Parse(File.ReadAllText("ilosc.txt"));

                    float floatingAmount = amountOfGrams / 100;

                    arg[0] = product.Name;
                    arg[1] = amountOfGrams.ToString();
                    arg[2] = (product.B * floatingAmount).ToString();
                    arg[3] = (product.T * floatingAmount ).ToString();
                    arg[4] = (product.W * floatingAmount).ToString();
                    arg[5] = (product.Kcal * floatingAmount).ToString();
                    arg[6] = product.Barcode.ToString();

                    var itm = new ListViewItem(arg);

                    File.WriteAllText("ilosc.txt", "");

                    switch (NumberOfClickedList)
                    {
                        case 1:
                            {
                                listView1.Items.Add(itm);

                                break;
                            }
                        case 2:
                            {
                                listView2.Items.Add(itm);
                                break;
                            }
                        case 3:
                            {
                                listView3.Items.Add(itm);
                                break;
                            }
                        case 4:
                            {
                                listView4.Items.Add(itm);
                                break;
                            }
                        case 5:
                            {
                                listView5.Items.Add(itm);
                                break;
                            }
                        default:
                            break;
                    }
                }
                NumberOfClickedList = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CheckIfAnyButtonIsNotEnabled() == false && CheckIfForm2IsOpen() == false)
            {
                timer1.Enabled = true;
                UnlockButtons();
            }
        }

        private void SetSettingsInListViews()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Produkt", 100);
            listView1.Columns.Add("G", 35);
            listView1.Columns.Add("B", 35);
            listView1.Columns.Add("T", 35);
            listView1.Columns.Add("W", 35);
            listView1.Columns.Add("Kcal", 35);
            listView1.Columns.Add("Kod kreskowy", 90);

            listView1.Columns.RemoveAt(0);
            //
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            listView2.Columns.Add("Produkt", 100);
            listView2.Columns.Add("B", 35);
            listView2.Columns.Add("T", 35);
            listView2.Columns.Add("W", 35);
            listView2.Columns.Add("Kcal", 35);
            listView2.Columns.Add("Kod kreskowy", 90);

            listView2.Columns.RemoveAt(0);
            //
            listView3.View = View.Details;
            listView3.GridLines = true;
            listView3.FullRowSelect = true;

            listView3.Columns.Add("Produkt", 100);
            listView3.Columns.Add("B", 35);
            listView3.Columns.Add("T", 35);
            listView3.Columns.Add("W", 35);
            listView3.Columns.Add("Kcal", 35);
            listView3.Columns.Add("Kod kreskowy", 90);

            listView3.Columns.RemoveAt(0);
            //
            listView4.View = View.Details;
            listView4.GridLines = true;
            listView4.FullRowSelect = true;

            listView4.Columns.Add("Produkt", 100);
            listView4.Columns.Add("B", 35);
            listView4.Columns.Add("T", 35);
            listView4.Columns.Add("W", 35);
            listView4.Columns.Add("Kcal", 35);
            listView4.Columns.Add("Kod kreskowy", 90);

            listView4.Columns.RemoveAt(0);
            //
            listView5.View = View.Details;
            listView5.GridLines = true;
            listView5.FullRowSelect = true;

            listView5.Columns.Add("Produkt", 100);
            listView5.Columns.Add("B", 35);
            listView5.Columns.Add("T", 35);
            listView5.Columns.Add("W", 35);
            listView5.Columns.Add("Kcal", 35);
            listView5.Columns.Add("Kod kreskowy", 90);

            listView5.Columns.RemoveAt(0);
        }

        private void LockButtons()
        {
            lblAdd1.Enabled = false;
        }

        private void UnlockButtons()
        {
            lblAdd1.Enabled = true;
        }

        public bool CheckIfAnyButtonIsNotEnabled()
        {
            if (lblAdd1.Enabled == false || lblAdd2.Enabled == false || lblAdd3.Enabled == false || lblAdd4.Enabled == false || lblAdd5.Enabled == false)
            {
                return false;
            }
            else
            {
                return true; // przyciski dostępne
            }
        }

        public bool CheckIfForm2IsOpen()
        {
            string temp = File.ReadAllText("IsForm2Opened.txt");

            if(temp == "opened")
            {
                return true;
            }

            return false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        
    }
}
