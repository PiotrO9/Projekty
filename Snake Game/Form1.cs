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
        private GameEngine _gameEngine = new GameEngine();


        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.AddRange(_gameEngine.Pictures.ToArray());
            _gameEngine.SettingStartFields();
            _gameEngine.RandomFoodGenerating();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _gameEngine.IfSnakeAteFood();
            if (_gameEngine.TimerTick() == 0)
            {
                timer1.Enabled = false;
                _gameEngine.GameOver();
                timer1.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                _gameEngine.UserChangeDirectionRequest(Keys.Up);
            }
            else if (e.KeyCode == Keys.Down)
            {
                _gameEngine.UserChangeDirectionRequest(Keys.Down);
            }
            else if (e.KeyCode == Keys.Right)
            {
                _gameEngine.UserChangeDirectionRequest(Keys.Right);
            }
            else if (e.KeyCode == Keys.Left)
            {
                _gameEngine.UserChangeDirectionRequest(Keys.Left);
            }
        }
    }
}
