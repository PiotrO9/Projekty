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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void SwitchingEngines()
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


        }
    }
}
