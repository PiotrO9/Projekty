using Snake_Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        private GameEngine _generatingFields = new GameEngine();

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.AddRange(_generatingFields.)
        }
    }
}
