using Hanoi_Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi_Game
{
    public partial class Form1 : Form
    {
        private GameEngine _firstColumn = new GameEngine();
        private GameEngine _secoundColumn = new GameEngine(2);
        private GameEngine _thirdColumn = new GameEngine(3);

        int LastClickedNumber = 1;

        public Form1()
        {
            InitializeComponent();
            test();
            setRealHeight();
            PanelDisabling();
            PrintRollers();
        }

        public void PanelDisabling()
        {
            pnl1.Visible = false;
            pnl1.Enabled = false;

            pnl2.Visible = false;
            pnl2.Enabled = false;

            pnl3.Visible = false;
            pnl3.Enabled = false;

            pnl4.Visible = false;
            pnl4.Enabled = false;

            pnl5.Visible = false;
            pnl5.Enabled = false;

            pnl6.Visible = false;
            pnl6.Enabled = false;

            pnl7.Visible = false;
            pnl7.Enabled = false;
        }

        public void test()
        {
            _firstColumn.Column[0].panel = pnl4;
            _firstColumn.Column[1].panel = pnl3;
            _firstColumn.Column[2].panel = pnl2;
            _firstColumn.Column[3].panel = pnl1;
        }

        public void setRealHeight()
        {
            _firstColumn.Column[0].panel.Top = 200;

            int length = _firstColumn.Column.Count();

            for (int i = 1; i < length; i++)
            {
                _firstColumn.Column[i].panel.Top = _firstColumn.Column[i - 1].panel.Top - 10;
            }

        }

        public void PrintRollers()
        {
            foreach (var item in _firstColumn.Column)
            {
                if (item != null)
                {
                    item.panel.Visible = true;
                    item.panel.Enabled = true;
                }
            }
        }


        public void SetLocation(int x, int y)
        {
            ;
        }

        public void PrintingColumns()
        {
            ;
        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            LastClickedNumber = 1;
        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            LastClickedNumber = 2;
        }

        private void pnl3_Click(object sender, EventArgs e)
        {
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
        }

        private void pnl5_Click(object sender, EventArgs e)
        {
        }

        private void pnl6_Click(object sender, EventArgs e)
        {
        }

        private void pnl7_Click(object sender, EventArgs e)
        {
        }

        private void pnlPin2_Click(object sender, EventArgs e)
        {

        }

        private void pnlPin3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPin1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } // class
}
