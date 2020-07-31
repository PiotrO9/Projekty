using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;

        int Red = 0;
        int Green = 0;
        int Blue = 0;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 1);
        }

        public void penColorChange()
        {
            pen.Color = Color.FromArgb(Red, Green, Blue);
        }

        public void panelColorUpdate()
        {
            panel2.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void trackBarR_ValueChanged(object sender, EventArgs e)
        {
            Red = trackBarR.Value;
            label1.Text = Red.ToString();
            penColorChange();
            panelColorUpdate();
        }

        private void trackBarG_ValueChanged(object sender, EventArgs e)
        {
            Green = trackBarG.Value;
            label2.Text = Green.ToString();
            penColorChange();
            panelColorUpdate();
        }

        private void trackBarB_ValueChanged(object sender, EventArgs e)
        {
            Blue = trackBarB.Value;
            label3.Text = Blue.ToString();
            penColorChange();
            panelColorUpdate();
        }

        private void trackBarW_ValueChanged(object sender, EventArgs e)
        {
            lblW.Text = trackBarW.Value.ToString();
            pen.Width = trackBarW.Value;
        }
    }
}
