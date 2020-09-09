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
            if (_gameEngine.Timer_tick() == true)
            {
                _gameEngine.Timer_tick();
                _gameEngine.AddPointsByTime();
                label1.Text = _gameEngine.ReturnPointsAmount().ToString();
                lblAomuntOfRows.Text = _gameEngine.ReturnRowsAmount().ToString();

                lblBlue.Text = _gameEngine.ReturnAmountOfColors(4).ToString();
                lblOrange.Text = _gameEngine.ReturnAmountOfColors(3).ToString();
                lblYellow.Text = _gameEngine.ReturnAmountOfColors(2).ToString();
                lblGreen.Text = _gameEngine.ReturnAmountOfColors(1).ToString();
                lblRed.Text = _gameEngine.ReturnAmountOfColors(0).ToString();
            }
        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _gameEngine.Pressing(Keys.Left);
            }
            else if (e.KeyCode == Keys.Right)
            {
                _gameEngine.Pressing(Keys.Right);
            }
            else if (e.KeyCode == Keys.Down)
            {
                timer1.Interval = 100;
            }
        }

        private void Tetris_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                timer1.Interval = 500;
            }

            _gameEngine.Unpressing();
        }

    }
}
