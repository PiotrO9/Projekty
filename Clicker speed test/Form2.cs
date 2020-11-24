using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_speed_test
{
    public partial class Form2 : Form
    {
        float clickPerSecound;
        float clicks;
        float seconds;


        public Form2(float s, float click)
        {
            InitializeComponent();

            clickPerSecound = click / s;
            clicks = click;
            seconds = s;

            lblC.Text = click.ToString();
            label1.Text = clickPerSecound.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"plik.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
            }
            else
            {
                sw = new StreamWriter(path, true);
                sw.WriteLine("CPS: " + clickPerSecound + " ; " + "Clicks: " + clicks + " ; " + "Form: " + seconds + "s ; " + DateTime.Now);
                sw.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"plik.txt"))
            {
                Process.Start(@"plik.txt");
            }
            else
            {
                MessageBox.Show("Nie istnieje plik do zapisu");
            }
        }
    }
}
