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
            _firstColumn.Column[0].panel = pnl5;
            _secoundColumn.Column[0].panel = pnl3;
            _secoundColumn.Column[1].panel = pnl2;
            _secoundColumn.Column[2].panel = pnl1;

            int i = 0;

            foreach (var item in _secoundColumn.Column)
            {
                item.panel.Left += 100;
                i = i + 10;
            }
        }

        public void setRealHeight()
        {
            if (_firstColumn.Column.Count() != 0)
            {
                _firstColumn.Column[0].panel.Top = 200;

                int length = _firstColumn.Column.Count();

                for (int i = 1; i < length; i++)
                {
                    _firstColumn.Column[i].panel.Top = _firstColumn.Column[i - 1].panel.Top - 10;
                }
            }

            if (_secoundColumn.Column.Count() != 0)
            {
                _secoundColumn.Column[0].panel.Top = 200;

                int length = _secoundColumn.Column.Count();

                for (int i = 1; i < length; i++)
                {
                    _secoundColumn.Column[i].panel.Top = _secoundColumn.Column[i - 1].panel.Top - 10;
                }

            }

            if (_thirdColumn.Column.Count() != 0)
            {
                _thirdColumn.Column[0].panel.Top = 200;

                int length = _thirdColumn.Column.Count();

                for (int i = 1; i < length; i++)
                {
                    _thirdColumn.Column[i].panel.Top = _thirdColumn.Column[i - 1].panel.Top - 10;
                }

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

            foreach (var item in _secoundColumn.Column)
            {
                if (item != null)
                {
                    item.panel.Visible = true;
                    item.panel.Enabled = true;
                }
            }

            foreach (var item in _thirdColumn.Column)
            {
                if (item != null)
                {
                    item.panel.Visible = true;
                    item.panel.Enabled = true;
                }
            }
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
