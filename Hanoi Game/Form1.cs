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
            PanelDisabling();
            PrintingFirstColumn();
        }

        public int FromWhichCOlumn(int n)
        {
            if (_firstColumn.GetNumberFromWhichColumn(n) == 0)
            {
                if (_secoundColumn.GetNumberFromWhichColumn(n) == 0)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        public void SelectRightList(int n)
        {
            if (FromWhichCOlumn(n) == 1)
            {
                _firstColumn.CheckLastClickedRoller(n);
            }
            else if (FromWhichCOlumn(n) == 2)
            {
                _secoundColumn.CheckLastClickedRoller(n);
            }
            else if (FromWhichCOlumn(n) == 3)
            {
                _thirdColumn.CheckLastClickedRoller(n);
            }
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

        public void PrintingFirstColumn()
        {
            if (_firstColumn.GetAmountOfRollers() == 3)
            {
                pnl3.Enabled = true;
                pnl3.Visible = true;
                pnl3.Location = new Point(pnl3.Location.X, 200);

                pnl2.Enabled = true;
                pnl2.Visible = true;
                pnl2.Location = new Point(pnl2.Location.X, 190);

                pnl1.Enabled = true;
                pnl1.Visible = true;
                pnl1.Location = new Point(pnl1.Location.X, 180);
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
            SelectRightList(1);
            LastClickedNumber = 1;
        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            SelectRightList(2);
            LastClickedNumber = 2;
        }

        private void pnl3_Click(object sender, EventArgs e)
        {
            SelectRightList(3);
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
            SelectRightList(4);
        }

        private void pnl5_Click(object sender, EventArgs e)
        {
            SelectRightList(5);
        }

        private void pnl6_Click(object sender, EventArgs e)
        {
            SelectRightList(6);
        }

        private void pnl7_Click(object sender, EventArgs e)
        {
            SelectRightList(7);
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
