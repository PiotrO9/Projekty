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
    public partial class Form2 : Form
    {
        int test = 1;

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

            string[] arg = new string[4];
            var itm = new ListViewItem(arg);

            arg[0] = "test1";
            arg[1] = "3";
            arg[2] = "4";
            arg[3] = "5.76";

            itm = new ListViewItem(arg);
            listView1.Items.Add(itm);

            arg[0] = "test2";
            arg[1] = "5";
            arg[2] = "6.8";
            arg[3] = "5.7";

            itm = new ListViewItem(arg);
            listView1.Items.Add(itm);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            test++;
            btnTest.Text = test.ToString();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
