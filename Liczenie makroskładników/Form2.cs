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
    public partial class Form2 : Form
    {
        Product productToSend;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Produkt", 100);
            listView1.Columns.Add("B", 35);
            listView1.Columns.Add("T", 35);
            listView1.Columns.Add("W", 35);
            listView1.Columns.Add("Kcal", 35);
            listView1.Columns.Add("Kod kreskowy", 90);

            List<Product> ListOfProducts = ImportProductsToList.ImportProducts();

            foreach (var product in ListOfProducts)
            {
                string[] arg = new string[6];

                arg[0] = product.Name;
                arg[1] = product.B.ToString();
                arg[2] = product.T.ToString();
                arg[3] = product.W.ToString();
                arg[4] = product.Kcal.ToString();
                arg[5] = product.Barcode.ToString();

                var itm = new ListViewItem(arg);
                listView1.Items.Add(itm);
            }

            //string[] arg = new string[4];
            //var itm = new ListViewItem(arg);

            //arg[0] = "test1";
            //arg[1] = "3";
            //arg[2] = "4";
            //arg[3] = "5.76";

            //itm = new ListViewItem(arg);
            //listView1.Items.Add(itm);

            //arg[0] = "test2";
            //arg[1] = "5";
            //arg[2] = "6.8";
            //arg[3] = "5.7";

            //itm = new ListViewItem(arg);
            //listView1.Items.Add(itm);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            var temp = listView1.SelectedItems[0];

            Product product = new Product();

            char[] tempCharArray = new char[] { '{' , '}' };

            product.Name = temp.SubItems[0].ToString().Trim(tempCharArray).Remove(0, 17).Remove(0,1);

            //product.Name.Trim(tempCharArray);
            //product.Name.Remove(0, 17);

            product.B = float.Parse(temp.SubItems[1].Text);
            product.T = float.Parse(temp.SubItems[2].Text);
            product.W = float.Parse(temp.SubItems[3].Text);
            product.Kcal = int.Parse(temp.SubItems[4].Text);
            product.Barcode = long.Parse(temp.SubItems[5].Text);

            productToSend = product;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string tempString = ProductToText.ConvertProductIntoText(productToSend);

            //FileStream test =  File.OpenWrite("wybor.txt");

            StreamWriter streamW = new StreamWriter("wybor.txt");
            streamW.WriteLine(tempString);
            ;
            streamW.Close();

            this.Close();  
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ;
        }
    }
}
