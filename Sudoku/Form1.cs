using Sudoku.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        private GameEngine _generatingCells = new GameEngine();

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.AddRange(_generatingCells.Buttons.ToArray());
            _generatingCells.AddingValues();
            _generatingCells.buttonsDisabling();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(1);
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(2);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(3);
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(4);
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(5);
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(6);
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(7);
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(8);
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            _generatingCells.putValueInButtons(9);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

