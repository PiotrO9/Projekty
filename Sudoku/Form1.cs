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
        private readonly GameEngine _generatingCells = new GameEngine();

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.AddRange(_generatingCells.Buttons.ToArray());
        }
    }
}
