using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_speed_test
{
    public partial class Form2 : Form
    {
        public Form2(float s, float click)
        {
            InitializeComponent();

            float clickPerSecound = click / s;

            lblC.Text = click.ToString();
            label1.Text = clickPerSecound.ToString();
        }

    }
}
