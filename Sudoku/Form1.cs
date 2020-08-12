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
        int timeCountingS;
        int timeCountingM;
        string messageForWinner;

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.AddRange(_generatingCells.Buttons.ToArray());
            _generatingCells.AddingValues();
            _generatingCells.buttonsDisabling();
            timer1.Enabled = true;
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

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _generatingCells.Clear();
            _generatingCells.AddingValues();
            _generatingCells.buttonsDisabling();
            timeCountingS = 0;
            timeCountingM = 0;
            messageForWinner = string.Empty;
            timer1.Enabled = true;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            _generatingCells.ClearLastPositionValue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrintingTime();
            if (_generatingCells.checkIfWin() == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("Rozwiązałeś sudoku w " + messageForWinner);
            }
        }

        private void PrintingTime()
        {
            if (timeCountingS >= 60)
            {
                timeCountingM++;
                timeCountingS = 0;
            }
            timeCountingS++;

            if (timeCountingM > 0)
            {
                messageForWinner = timeCountingM.ToString() + " : " + timeCountingS.ToString();
                if (timeCountingS < 10)
                {
                    messageForWinner = timeCountingM.ToString() + " : 0" + timeCountingS.ToString();
                }
                label8.Text = messageForWinner;
            }
            else
            {
                messageForWinner = "0" + " : " + timeCountingS.ToString();
                if (timeCountingS < 10)
                {
                    messageForWinner = "0" + " : 0" + timeCountingS.ToString();
                }
                label8.Text = messageForWinner;
            }
        }

        private void łatwyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _generatingCells.SetDifficulty();
            _generatingCells.Clear();
            _generatingCells.AddingValues();
            _generatingCells.buttonsDisabling();
            timeCountingS = 0;
            timeCountingM = 0;
            messageForWinner = string.Empty;
            timer1.Enabled = true;
        }

        private void średniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _generatingCells.SetDifficulty(36);
            _generatingCells.Clear();
            _generatingCells.AddingValues();
            _generatingCells.buttonsDisabling();
            timeCountingS = 0;
            timeCountingM = 0;
            messageForWinner = string.Empty;
            timer1.Enabled = true;
        }

        private void trudnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _generatingCells.SetDifficulty(28);
            _generatingCells.Clear();
            _generatingCells.AddingValues();
            _generatingCells.buttonsDisabling();
            timeCountingS = 0;
            timeCountingM = 0;
            messageForWinner = string.Empty;
            timer1.Enabled = true;
        }
    }


}

