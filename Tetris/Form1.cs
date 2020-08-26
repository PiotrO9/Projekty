using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Models.Engines;

namespace Tetris
{
    public partial class Tetris : Form
    {
        private GameEngine _gameEngine = new GameEngine();

        public Tetris()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.AddRange(_gameEngine.Pictures.ToArray());
            _gameEngine.GeneratingBlock();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _gameEngine.Timer_tick();
        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
