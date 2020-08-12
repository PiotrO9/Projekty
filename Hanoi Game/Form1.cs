using Hanoi_Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Form1()
        {
            InitializeComponent();
            PanelDisabling();
            PrintingFirstColumn();
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

        private void pnl1_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(1);
        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(2);
        }

        private void pnl3_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(3);
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(4);
        }

        private void pnl5_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(5);
        }

        private void pnl6_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(6);
        }

        private void pnl7_Click(object sender, EventArgs e)
        {
            _firstColumn.CheckLastClickedRoller(7);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            int tempGet = _firstColumn.GetLastClickedRoller();
            int tempFirstColumn = _firstColumn.GetNumberFromWhichColumn(tempGet);
            int tempSecondColumn = _secoundColumn.GetNumberFromWhichColumn(tempGet);
            int tempThirdColumn = _thirdColumn.GetNumberFromWhichColumn(tempGet);
            int tempRightColumn;

            //Sprawdzanie w której kolumnie leży ostatnio kliknięty krążek

            if (tempFirstColumn == 0)
            {
                if (tempSecondColumn == 0)
                {
                    tempRightColumn = tempThirdColumn;
                }
                else
                {
                    tempRightColumn = tempSecondColumn;
                }
            }
            else
            {
                tempRightColumn = tempFirstColumn;
            }

            ///

            if (tempGet == 1)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(1);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl1.Location = new Point(205, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        int temp = _secoundColumn.Column.Count;
                        int calc = temp * 10;

                        Roller roller = new Roller(1);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl1.Location = new Point(205, 200 - calc);
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(1);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl1.Location = new Point(205, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        int temp = _secoundColumn.Column.Count;
                        int calc = temp * 10;

                        Roller roller = new Roller(1);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl1.Location = new Point(205, 200 - calc);
                    }
                }
            }
            else if (tempGet == 2)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(2);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl2.Location = new Point(200, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 2)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(2);
                            _secoundColumn.Column.Add(roller);
                            _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                            pnl2.Location = new Point(200, 200 - calc);
                        }
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(2);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl2.Location = new Point(200, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 2)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(2);
                            _secoundColumn.Column.Add(roller);
                            _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                            pnl2.Location = new Point(200, 200 - calc);
                        }
                    }
                }
            }
            else if (tempGet == 3)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(3);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl3.Location = new Point(195, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 3)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(3);
                            _secoundColumn.Column.Add(roller);
                            _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                            pnl3.Location = new Point(195, 200 - calc);
                        }
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(3);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl3.Location = new Point(195, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 3)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(3);
                            _secoundColumn.Column.Add(roller);
                            _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                            pnl3.Location = new Point(195, 200 - calc);
                        }
                    }
                }
            }
            else if (tempGet == 4)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(4);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl4.Location = new Point(190, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 4)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(4);
                            _secoundColumn.Column.Add(roller);
                            _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                            pnl4.Location = new Point(190, 200 - calc);
                        }
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(4);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl4.Location = new Point(190, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 4)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(4);
                            _secoundColumn.Column.Add(roller);
                            _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                            pnl4.Location = new Point(190, 200 - calc);
                        }
                    }
                }
            }
            else if (tempGet == 5)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(5);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl5.Location = new Point(185, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 5)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(5);
                            _secoundColumn.Column.Add(roller);
                            _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                            pnl5.Location = new Point(185, 200 - calc);
                        }
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(5);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl5.Location = new Point(185, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 5)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(5);
                            _secoundColumn.Column.Add(roller);
                            _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                            pnl5.Location = new Point(185, 200 - calc);
                        }
                    }
                }
            }
            else if (tempGet == 6)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(6);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl6.Location = new Point(180, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 6)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(6);
                            _secoundColumn.Column.Add(roller);
                            _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                            pnl6.Location = new Point(180, 200 - calc);
                        }
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(6);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl6.Location = new Point(180, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 6)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(6);
                            _secoundColumn.Column.Add(roller);
                            _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                            pnl6.Location = new Point(180, 200 - calc);
                        }
                    }
                }
            }
            else if (tempGet == 7)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(7);
                        _secoundColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl7.Location = new Point(175, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 7)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(7);
                            _secoundColumn.Column.Add(roller);
                            _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                            pnl7.Location = new Point(175, 200 - calc);
                        }
                    }
                }
                else if (tempRightColumn == 3)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(7);
                        _secoundColumn.Column.Add(roller);
                        _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                        pnl7.Location = new Point(175, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        if (_secoundColumn.Column[_secoundColumn.Column.Count - 1].number > 7)
                        {
                            int temp = _secoundColumn.Column.Count;
                            int calc = temp * 10;

                            Roller roller = new Roller(7);
                            _secoundColumn.Column.Add(roller);
                            _thirdColumn.Column.RemoveAt(_thirdColumn.Column.Count - 1);
                            pnl7.Location = new Point(175, 200 - calc);
                        }
                    }
                }
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            int tempGet = _firstColumn.GetLastClickedRoller();
            int tempFirstColumn = _firstColumn.GetNumberFromWhichColumn(tempGet);
            int tempSecondColumn = _secoundColumn.GetNumberFromWhichColumn(tempGet);
            int tempThirdColumn = _thirdColumn.GetNumberFromWhichColumn(tempGet);
            int tempRightColumn;

            //Sprawdzanie w której kolumnie leży ostatnio kliknięty krążek

            if (tempFirstColumn == 0)
            {
                if (tempSecondColumn == 0)
                {
                    tempRightColumn = tempThirdColumn;
                }
                else
                {
                    tempRightColumn = tempSecondColumn;
                }
            }
            else
            {
                tempRightColumn = tempFirstColumn;
            }

            ///

            if (tempGet == 1)
            {
                if (tempRightColumn == 1)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(1);
                        _thirdColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl1.Location = new Point(325, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        int temp = _thirdColumn.Column.Count;
                        int calc = temp * 10;

                        Roller roller = new Roller(1);
                        _thirdColumn.Column.Add(roller);
                        _firstColumn.Column.RemoveAt(_firstColumn.Column.Count - 1);
                        pnl1.Location = new Point(325, 200 - calc);
                    }
                }
                else if (tempRightColumn == 2)
                {
                    if (_secoundColumn.Column.Count == 0)
                    {
                        Roller roller = new Roller(1);
                        _thirdColumn.Column.Add(roller);
                        _secoundColumn.Column.RemoveAt(_secoundColumn.Column.Count - 1);
                        pnl1.Location = new Point(325, 200);
                    }
                    else if (_secoundColumn.Column.Count != 0)
                    {
                        int temp = _thirdColumn.Column.Count;
                        int calc = temp * 10;

                        Roller roller = new Roller(1);
                        _thirdColumn.Column.Add(roller);
                        _secoundColumn.Column.RemoveAt(_secoundColumn.Column.Count - 1);
                        pnl1.Location = new Point(325, 200 - calc);
                    }
                }
            }
        }
    } // class
}
