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

        int[] NumberOfClickedItemInLists = new int[5];
        bool[] IsNumberOfClickedItemInListsChanged = new bool[5];

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
            timer1.Enabled = false;
        }

        private void lblAdd3_Click(object sender, EventArgs e)
        {
            NumberOfClickedList = 3;
            lblAdd3.Enabled = false;
            form2Opening();
            timer1.Enabled = false;
        }
        private void lblAdd4_Click(object sender, EventArgs e)
        {
            NumberOfClickedList = 4;
            lblAdd4.Enabled = false;
            form2Opening();
            timer1.Enabled = false;
        }

        private void lblAdd5_Click(object sender, EventArgs e)
        {
            NumberOfClickedList = 5;
            lblAdd5.Enabled = false;
            form2Opening();
            timer1.Enabled = false;
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

                    float amountOfGrams = float.Parse(File.ReadAllText("ilosc.txt"));

                    float floatingAmount = amountOfGrams / 100;

                    arg[0] = product.Name;
                    arg[1] = amountOfGrams.ToString();
                    arg[2] = Math.Round(product.B * floatingAmount,1).ToString();
                    arg[3] = Math.Round(product.T * floatingAmount,1).ToString();
                    arg[4] = Math.Round(product.W * floatingAmount,1).ToString();
                    arg[5] = (product.Kcal * floatingAmount).ToString();
                    arg[6] = product.Barcode.ToString();

                    var itm = new ListViewItem(arg);

                    File.WriteAllText("ilosc.txt", "");

                    switch (NumberOfClickedList)
                    {
                        case 1:
                            {
                                listView1.Items.Add(itm);
                                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                CalculateMacros();
                                break;
                            }
                        case 2:
                            {
                                listView2.Items.Add(itm);
                                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                CalculateMacros();
                                break;
                            }
                        case 3:
                            {
                                listView3.Items.Add(itm);
                                listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                CalculateMacros();
                                break;
                            }
                        case 4:
                            {
                                listView4.Items.Add(itm);
                                listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                CalculateMacros();
                                break;
                            }
                        case 5:
                            {
                                listView5.Items.Add(itm);
                                listView5.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                CalculateMacros();
                                break;
                            }
                        default:
                            break;
                    }
                }
                NumberOfClickedList = 0;
                File.WriteAllText("wybor.txt","");
                File.WriteAllText("ilosc.txt", "");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(CheckIfAnyButtonIsNotEnabled() == false && CheckIfForm2IsOpen() == false && CheckIfFileIsNotZero.CheckIfFileIsNotZeroFunction() == true) // Tutaj sprawdzić czy 3 forma jest zamknięta
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
            listView2.Columns.Add("G", 35);
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
            listView3.Columns.Add("G", 35);
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
            listView4.Columns.Add("G", 35);
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
            listView5.Columns.Add("G", 35);
            listView5.Columns.Add("B", 35);
            listView5.Columns.Add("T", 35);
            listView5.Columns.Add("W", 35);
            listView5.Columns.Add("Kcal", 35);
            listView5.Columns.Add("Kod kreskowy", 90);

            listView5.Columns.RemoveAt(0);
        }

        private void UnlockButtons()
        {
            lblAdd1.Enabled = true;
            lblAdd2.Enabled = true;
            lblAdd3.Enabled = true;
            lblAdd4.Enabled = true;
            lblAdd5.Enabled = true;
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

        private void CalculateMacros()
        {
            lblBscore.Text = CalculateB().ToString();
            lblTscore.Text = CalculateT().ToString();
            lblWscore.Text = CalculateW().ToString();
            lblKcalscore.Text = CalculateKcal().ToString();
        }

        private float CalculateB()
        {
            float sum = 0;

            List<ListView> listOfListViews = new List<ListView>();
            listOfListViews.Add(listView1);
            listOfListViews.Add(listView2);
            listOfListViews.Add(listView3);
            listOfListViews.Add(listView4);
            listOfListViews.Add(listView5);

            foreach (var list in listOfListViews)
            {
                for (int i = 0; i < list.Items.Count; i++)
                {
                    var temp = list.Items[i].SubItems[2];
                    sum += float.Parse(temp.Text);
                }
            }
            return sum;
        }

        private float CalculateT()
        {
            float sum = 0;

            List<ListView> listOfListViews = new List<ListView>();
            listOfListViews.Add(listView1);
            listOfListViews.Add(listView2);
            listOfListViews.Add(listView3);
            listOfListViews.Add(listView4);
            listOfListViews.Add(listView5);

            foreach (var list in listOfListViews)
            {
                for (int i = 0; i < list.Items.Count; i++)
                {
                    var temp = list.Items[i].SubItems[3];
                    sum += float.Parse(temp.Text);
                }
            }
            return sum;
        }

        private float CalculateW()
        {
            float sum = 0;

            List<ListView> listOfListViews = new List<ListView>();
            listOfListViews.Add(listView1);
            listOfListViews.Add(listView2);
            listOfListViews.Add(listView3);
            listOfListViews.Add(listView4);
            listOfListViews.Add(listView5);

            foreach (var list in listOfListViews)
            {
                for (int i = 0; i < list.Items.Count; i++)
                {
                    var temp = list.Items[i].SubItems[4];
                    sum += float.Parse(temp.Text);
                }
            }
            return sum;
        }
        private float CalculateKcal()
        {
            float sum = 0;

            List<ListView> listOfListViews = new List<ListView>();
            listOfListViews.Add(listView1);
            listOfListViews.Add(listView2);
            listOfListViews.Add(listView3);
            listOfListViews.Add(listView4);
            listOfListViews.Add(listView5);

            foreach (var list in listOfListViews)
            {
                for (int i = 0; i < list.Items.Count; i++)
                {
                    var temp = list.Items[i].SubItems[5];
                    sum += float.Parse(temp.Text);
                }
            }
            return sum;
        }
        private void btnLW1del_Click(object sender, EventArgs e)
        {
            if(IsNumberOfClickedItemInListsChanged[0] == true)
            {
                listView1.Items.RemoveAt(NumberOfClickedItemInLists[0]);
                NumberOfClickedItemInLists[0] = 0;
                IsNumberOfClickedItemInListsChanged[0] = false;
                CalculateMacros();
            } 
        }

        private void btnLW2del_Click(object sender, EventArgs e)
        {
            if (IsNumberOfClickedItemInListsChanged[1] == true)
            {
                listView2.Items.RemoveAt(NumberOfClickedItemInLists[1]);
                NumberOfClickedItemInLists[1] = 0;
                IsNumberOfClickedItemInListsChanged[1] = false;
                CalculateMacros();
            }
        }

        private void btnLW3del_Click(object sender, EventArgs e)
        {
            if (IsNumberOfClickedItemInListsChanged[2] == true)
            {
                listView3.Items.RemoveAt(NumberOfClickedItemInLists[2]);
                NumberOfClickedItemInLists[2] = 0;
                IsNumberOfClickedItemInListsChanged[2] = false;
                CalculateMacros();
            }
        }

        private void btnLW4del_Click(object sender, EventArgs e)
        {
            if (IsNumberOfClickedItemInListsChanged[3] == true)
            {
                listView4.Items.RemoveAt(NumberOfClickedItemInLists[3]);
                NumberOfClickedItemInLists[3] = 0;
                IsNumberOfClickedItemInListsChanged[3] = false;
                CalculateMacros();
            }
        }

        private void btnLW5del_Click(object sender, EventArgs e)
        {
            if (IsNumberOfClickedItemInListsChanged[4] == true)
            {
                listView5.Items.RemoveAt(NumberOfClickedItemInLists[4]);
                NumberOfClickedItemInLists[4] = 0;
                IsNumberOfClickedItemInListsChanged[4] = false;
                CalculateMacros();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            var temp = listView1.SelectedItems[0];
            int numberOfIndex = temp.Index;
            NumberOfClickedItemInLists[0] = numberOfIndex;
            IsNumberOfClickedItemInListsChanged[0] = true;
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            var temp = listView2.SelectedItems[0];
            int numberOfIndex = temp.Index;
            NumberOfClickedItemInLists[1] = numberOfIndex;
            IsNumberOfClickedItemInListsChanged[1] = true;
        }

        private void listView3_Click(object sender, EventArgs e)
        {
            var temp = listView3.SelectedItems[0];
            int numberOfIndex = temp.Index;
            NumberOfClickedItemInLists[2] = numberOfIndex;
            IsNumberOfClickedItemInListsChanged[2] = true;
        }

        private void listView4_Click(object sender, EventArgs e)
        {
            var temp = listView4.SelectedItems[0];
            int numberOfIndex = temp.Index;
            NumberOfClickedItemInLists[3] = numberOfIndex;
            IsNumberOfClickedItemInListsChanged[3] = true;
        }

        private void listView5_Click(object sender, EventArgs e)
        {
            var temp = listView5.SelectedItems[0];
            int numberOfIndex = temp.Index;
            NumberOfClickedItemInLists[4] = numberOfIndex;
            IsNumberOfClickedItemInListsChanged[4] = true;
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            CalculateMacros();
        }

        private void dodajPosiłekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void odczytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            string directory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.InitialDirectory = directory + "odczyt";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                var fileStream = openFileDialog.OpenFile();

                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();

               var ListOfWords = TextToList.method(fileContent);
                
         

            }
            else
            {
                MessageBox.Show("Wystąpił błąd otwierania pliku");
            }
        }

        private void zapisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CurrentTime = GetCurrentTime.GetCurrentTimeFunction();
            CurrentTime += ".txt";
            string directory = AppDomain.CurrentDomain.BaseDirectory;

            directory = directory.Remove(directory.Length - 1, 1);

            string path = @"odczyt\" + CurrentTime;

            File.CreateText(path);
            

            ;

            List<ListView> ListOfLists = new List<ListView>();

            ListOfLists.Add(listView1);
            ListOfLists.Add(listView2);
            ListOfLists.Add(listView3);
            ListOfLists.Add(listView4);
            ListOfLists.Add(listView5);

            

            foreach (var item in ListOfLists)
            {
                for (int i = 0; i < item.Items.Count; i++)
                {
                    string temp = "";

                    temp += item.Items[i].SubItems[0];
                    temp += ";";
                    temp += item.Items[i].SubItems[1];
                    temp += ";";
                    temp += item.Items[i].SubItems[2];
                    temp += ";";
                    temp += item.Items[i].SubItems[3];
                    temp += ";";
                    temp += item.Items[i].SubItems[4];
                    temp += ";";
                    temp += item.Items[i].SubItems[5];
                    temp += ";";
                    temp += item.Items[i].SubItems[6];
                    temp += ";";

                    // dodanie do
                }
            }

        }

        private void AddProductToEspeciallyList(int n,string s)
        {
            Product product = ImportOneProduct.ImportSingleProduct(s);

            string[] arg = new string[7];

            arg[0] = product.Name;
            arg[1] = "test";
            arg[2] = product.B.ToString();
            arg[3] = product.T.ToString();
            arg[4] = product.W.ToString();
            arg[5] = product.Kcal.ToString();
            arg[6] = product.Barcode.ToString();

            var itm = new ListViewItem(arg);
            switch (n)
            {
                case 1:
                    {
                        listView1.Items.Add(itm);
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
