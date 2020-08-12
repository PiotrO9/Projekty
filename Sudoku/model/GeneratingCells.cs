using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.model
{
    class GameEngine
    {
        public readonly List<Cell> _listOfCells = new List<Cell>();

        public IEnumerable<Button> Buttons => _listOfCells.Select(s => s.ButtonCell);

        public int mainX = 9;
        public int mainY = 9;

        private int currentDifficulty = 44;

        public GameEngine()
        {
            Generator();
        }

        private void Generator()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var cell = new Cell(i, j);
                    cell.CellClicked += Cell_CellClicked;

                    _listOfCells.Add(cell);
                }
            }
        }

        public void ClearLastPositionValue()
        {
            IEnumerable<Cell> query = _listOfCells.Where(_listOfCells => _listOfCells.X == mainX && _listOfCells.Y == mainY);

            foreach (var item in query)
            {
                item.UserValue = 0;
                item.ButtonCell.Text = string.Empty;
            }
        }

        public void FillLastPosition(int x, int y)
        {
            mainX = x;
            mainY = y;
        }

        public bool checkIfWin()
        {
            bool temp = true;

            foreach (var item in _listOfCells)
            {
                if (item.UserValue == item.GeneratedValue)
                {
                    temp = true;
                }
                else
                    return false;
            }

            return temp;
        }

        private void Cell_CellClicked(object sender, CellEventArgs e)
        {
            FillLastPosition(e.X, e.Y);
        }

        public void Clear()
        {
            _listOfCells.ForEach(cell => cell.Clear());
            _listOfCells.ForEach(cell => cell.ButtonCell.Enabled = true);
            _listOfCells.ForEach(cell => cell.ButtonCell.BackColor = Color.FromArgb(236, 233, 216));

        }

        public void UserClickedNumber(int n)
        {
            var activCell = this._listOfCells.Where(w => w.Active);
        }

        public int SetDifficulty(int difficulty = 44)
        {
            currentDifficulty = difficulty;
            return currentDifficulty;
        }

        public void AddingValues()
        {
            AddingValuesByCode();

            var rnd = new Random();

            int rand1; // ilosc operacji
            int rand2; // przesunięcie 3 kolumn,wierszy czy przesuniecie 1
            int rand3; // potrzebne do wylosowania typu operacji

            rand1 = rnd.Next(6, 13);

            for (int i = 0; i < rand1; i++)
            {
                rand2 = rnd.Next(1, 3);

                if (rand2 == 1)
                {
                    rand3 = rnd.Next(1, 3);
                }
                else
                    rand3 = rnd.Next(1, 7);

                SwitchRows(rand2, rand3);
            }

            //Pokazywanie losowo wybranych pól

            int temp = 0;
            int numberOfDifficulty = SetDifficulty(currentDifficulty);

            while (temp < numberOfDifficulty)
            {
                int randX = rnd.Next(0, 9);
                int randY = rnd.Next(0, 9);

                foreach (var item in _listOfCells)
                {
                    if (item.X == randX && item.Y == randY)
                    {
                        if (item.UserValue != 0)
                        {
                            continue;
                        }
                        else
                        {
                            item.UserValue = item.GeneratedValue;
                            item.ButtonCell.Text = item.UserValue.ToString();
                            item.ButtonCell.Enabled = false;
                            item.ButtonCell.BackColor = Color.Yellow;
                            temp++;
                        }
                    }
                }
            }
        }

        public void putValueInButtons(int number)
        {
            IEnumerable<Cell> query = _listOfCells.Where(_listOfCells => _listOfCells.X == mainX && _listOfCells.Y == mainY);

            foreach (var item in query)
            {
                item.UserValue = number;
                item.ButtonCell.Text = number.ToString();
                if (item.UserValue == item.GeneratedValue)
                {
                    item.ButtonCell.BackColor = Color.Green;
                    item.ButtonCell.Enabled = false;
                    mainX = 9;
                    mainY = 9;
                }
            }
        }

        public void buttonsDisabling()
        {
            foreach (var item in _listOfCells)
            {
                item.Active = false;
            }
        }

        private IEnumerable<Cell> GetElementOnDiagonal(int x, int y)
        {
            IEnumerable<Cell> queryI = _listOfCells.Where(_listOfCells => _listOfCells.X == x);
            IEnumerable<Cell> queryJ = _listOfCells.Where(_listOfCells => _listOfCells.Y == y);
            return queryI.Union(queryJ)
                         .Where(w => w.X != x || w.Y != y);
        }

        private IEnumerable<Cell> GetElementOnLocalField(int x, int y)
        {
            var numberOfField = GetNumberOfField(x, y);
            return _listOfCells.Where(w => GetNumberOfField(w.X, w.Y) == numberOfField);
        }

        private int GetNumberOfField(int x, int y)
        {
            if (x < 3)
            {
                if (y < 3)
                {
                    return 1;
                }
                if (y >= 3 && y < 6)
                {
                    return 4;
                }
                if (y >= 6)
                {
                    return 7;
                }
                else
                    return 0;
            }

            if (x >= 3 && x < 6)
            {
                if (y < 3)
                {
                    return 2;
                }
                if (y >= 3 && y < 6)
                {
                    return 5;
                }
                if (y >= 6)
                {
                    return 8;
                }
                else
                    return 0;
            }

            if (x >= 6)
            {
                if (y < 3)
                {
                    return 3;
                }
                if (y >= 3 && y < 6)
                {
                    return 6;
                }
                if (y >= 6)
                {
                    return 9;
                }
                else
                    return 0;
            }
            else
            {
                return 0;
            }
        }

        private void SwitchRows(int first, int secound)
        {
            if (first == 1)
            {
                if (secound == 1)
                {
                    SwitchRowsAlgorithmVertical(0, 6);
                    SwitchRowsAlgorithmVertical(1, 7);
                    SwitchRowsAlgorithmVertical(2, 8);
                }

                else if (secound == 2)
                {
                    SwitchRowsAlgorithmHorizontal(0, 6);
                    SwitchRowsAlgorithmHorizontal(1, 7);
                    SwitchRowsAlgorithmHorizontal(2, 8);
                }
            }
            else if (first == 2)
            {
                if (secound == 1)
                {
                    SwitchRowsAlgorithmVertical(0, 2);
                }
                else if (secound == 2)
                {
                    SwitchRowsAlgorithmVertical(3, 5);
                }
                else if (secound == 3)
                {
                    SwitchRowsAlgorithmVertical(6, 8);
                }
                else if (secound == 4)
                {
                    SwitchRowsAlgorithmHorizontal(0, 2);
                }
                else if (secound == 5)
                {
                    SwitchRowsAlgorithmHorizontal(3, 5);
                }
                else if (secound == 6)
                {
                    SwitchRowsAlgorithmHorizontal(6, 8);
                }
            }
        }

        private void SwitchRowsAlgorithmVertical(int firstCollumn, int secoundCollumn)
        {
            var firstCollection = _listOfCells.Where(w => w.Y == firstCollumn).ToList();
            var secoundCollection = _listOfCells.Where(w => w.Y == secoundCollumn).ToList();

            if (firstCollection.Count != secoundCollection.Count)
            {
                throw new ArgumentException("Kolekcje mają różną długość!");
            }

            for (int i = 0; i < firstCollection.Count; i++)
            {
                var temp = firstCollection[i].GeneratedValue;
                firstCollection[i].GeneratedValue = secoundCollection[i].GeneratedValue;
                secoundCollection[i].GeneratedValue = temp;
            }
        }

        private void SwitchRowsAlgorithmHorizontal(int firstCollumn, int secoundCollumn)
        {
            var firstCollection = _listOfCells.Where(w => w.X == firstCollumn).ToList();
            var secoundCollection = _listOfCells.Where(w => w.X == secoundCollumn).ToList();

            if (firstCollection.Count != secoundCollection.Count)
            {
                throw new ArgumentException("Kolekcje mają różną długość!");
            }

            for (int i = 0; i < firstCollection.Count; i++)
            {
                var temp = firstCollection[i].GeneratedValue;
                firstCollection[i].GeneratedValue = secoundCollection[i].GeneratedValue;
                secoundCollection[i].GeneratedValue = temp;
            }
        }

        private void AddingValuesByCode()
        {
            foreach (var item in _listOfCells)
            {
                //0
                if (item.X == 0 && item.Y == 0)
                    item.GeneratedValue = 7;
                if (item.X == 0 && item.Y == 1)
                    item.GeneratedValue = 3;
                if (item.X == 0 && item.Y == 2)
                    item.GeneratedValue = 5;
                if (item.X == 0 && item.Y == 3)
                    item.GeneratedValue = 6;
                if (item.X == 0 && item.Y == 4)
                    item.GeneratedValue = 1;
                if (item.X == 0 && item.Y == 5)
                    item.GeneratedValue = 4;
                if (item.X == 0 && item.Y == 6)
                    item.GeneratedValue = 8;
                if (item.X == 0 && item.Y == 7)
                    item.GeneratedValue = 9;
                if (item.X == 0 && item.Y == 8)
                    item.GeneratedValue = 2;
                //1
                if (item.X == 1 && item.Y == 0)
                    item.GeneratedValue = 8;
                if (item.X == 1 && item.Y == 1)
                    item.GeneratedValue = 4;
                if (item.X == 1 && item.Y == 2)
                    item.GeneratedValue = 2;
                if (item.X == 1 && item.Y == 3)
                    item.GeneratedValue = 9;
                if (item.X == 1 && item.Y == 4)
                    item.GeneratedValue = 7;
                if (item.X == 1 && item.Y == 5)
                    item.GeneratedValue = 3;
                if (item.X == 1 && item.Y == 6)
                    item.GeneratedValue = 5;
                if (item.X == 1 && item.Y == 7)
                    item.GeneratedValue = 6;
                if (item.X == 1 && item.Y == 8)
                    item.GeneratedValue = 1;
                //2
                if (item.X == 2 && item.Y == 0)
                    item.GeneratedValue = 9;
                if (item.X == 2 && item.Y == 1)
                    item.GeneratedValue = 6;
                if (item.X == 2 && item.Y == 2)
                    item.GeneratedValue = 1;
                if (item.X == 2 && item.Y == 3)
                    item.GeneratedValue = 2;
                if (item.X == 2 && item.Y == 4)
                    item.GeneratedValue = 8;
                if (item.X == 2 && item.Y == 5)
                    item.GeneratedValue = 5;
                if (item.X == 2 && item.Y == 6)
                    item.GeneratedValue = 3;
                if (item.X == 2 && item.Y == 7)
                    item.GeneratedValue = 7;
                if (item.X == 2 && item.Y == 8)
                    item.GeneratedValue = 4;

                ///1
                //3

                if (item.X == 3 && item.Y == 0)
                    item.GeneratedValue = 2;
                if (item.X == 3 && item.Y == 1)
                    item.GeneratedValue = 8;
                if (item.X == 3 && item.Y == 2)
                    item.GeneratedValue = 6;
                if (item.X == 3 && item.Y == 3)
                    item.GeneratedValue = 3;
                if (item.X == 3 && item.Y == 4)
                    item.GeneratedValue = 4;
                if (item.X == 3 && item.Y == 5)
                    item.GeneratedValue = 9;
                if (item.X == 3 && item.Y == 6)
                    item.GeneratedValue = 1;
                if (item.X == 3 && item.Y == 7)
                    item.GeneratedValue = 5;
                if (item.X == 3 && item.Y == 8)
                    item.GeneratedValue = 7;
                //4
                if (item.X == 4 && item.Y == 0)
                    item.GeneratedValue = 4;
                if (item.X == 4 && item.Y == 1)
                    item.GeneratedValue = 1;
                if (item.X == 4 && item.Y == 2)
                    item.GeneratedValue = 3;
                if (item.X == 4 && item.Y == 3)
                    item.GeneratedValue = 8;
                if (item.X == 4 && item.Y == 4)
                    item.GeneratedValue = 5;
                if (item.X == 4 && item.Y == 5)
                    item.GeneratedValue = 7;
                if (item.X == 4 && item.Y == 6)
                    item.GeneratedValue = 9;
                if (item.X == 4 && item.Y == 7)
                    item.GeneratedValue = 2;
                if (item.X == 4 && item.Y == 8)
                    item.GeneratedValue = 6;
                //5
                if (item.X == 5 && item.Y == 0)
                    item.GeneratedValue = 5;
                if (item.X == 5 && item.Y == 1)
                    item.GeneratedValue = 7;
                if (item.X == 5 && item.Y == 2)
                    item.GeneratedValue = 9;
                if (item.X == 5 && item.Y == 3)
                    item.GeneratedValue = 1;
                if (item.X == 5 && item.Y == 4)
                    item.GeneratedValue = 2;
                if (item.X == 5 && item.Y == 5)
                    item.GeneratedValue = 6;
                if (item.X == 5 && item.Y == 6)
                    item.GeneratedValue = 4;
                if (item.X == 5 && item.Y == 7)
                    item.GeneratedValue = 3;
                if (item.X == 5 && item.Y == 8)
                    item.GeneratedValue = 8;

                ///2
                //6

                if (item.X == 6 && item.Y == 0)
                    item.GeneratedValue = 1;
                if (item.X == 6 && item.Y == 1)
                    item.GeneratedValue = 5;
                if (item.X == 6 && item.Y == 2)
                    item.GeneratedValue = 7;
                if (item.X == 6 && item.Y == 3)
                    item.GeneratedValue = 4;
                if (item.X == 6 && item.Y == 4)
                    item.GeneratedValue = 9;
                if (item.X == 6 && item.Y == 5)
                    item.GeneratedValue = 2;
                if (item.X == 6 && item.Y == 6)
                    item.GeneratedValue = 6;
                if (item.X == 6 && item.Y == 7)
                    item.GeneratedValue = 8;
                if (item.X == 6 && item.Y == 8)
                    item.GeneratedValue = 3;

                //7

                if (item.X == 7 && item.Y == 0)
                    item.GeneratedValue = 6;
                if (item.X == 7 && item.Y == 1)
                    item.GeneratedValue = 9;
                if (item.X == 7 && item.Y == 2)
                    item.GeneratedValue = 4;
                if (item.X == 7 && item.Y == 3)
                    item.GeneratedValue = 7;
                if (item.X == 7 && item.Y == 4)
                    item.GeneratedValue = 3;
                if (item.X == 7 && item.Y == 5)
                    item.GeneratedValue = 8;
                if (item.X == 7 && item.Y == 6)
                    item.GeneratedValue = 2;
                if (item.X == 7 && item.Y == 7)
                    item.GeneratedValue = 1;
                if (item.X == 7 && item.Y == 8)
                    item.GeneratedValue = 5;

                //8
                if (item.X == 8 && item.Y == 0)
                    item.GeneratedValue = 3;
                if (item.X == 8 && item.Y == 1)
                    item.GeneratedValue = 2;
                if (item.X == 8 && item.Y == 2)
                    item.GeneratedValue = 8;
                if (item.X == 8 && item.Y == 3)
                    item.GeneratedValue = 5;
                if (item.X == 8 && item.Y == 4)
                    item.GeneratedValue = 6;
                if (item.X == 8 && item.Y == 5)
                    item.GeneratedValue = 1;
                if (item.X == 8 && item.Y == 6)
                    item.GeneratedValue = 7;
                if (item.X == 8 && item.Y == 7)
                    item.GeneratedValue = 4;
                if (item.X == 8 && item.Y == 8)
                    item.GeneratedValue = 9;
            }
        }


    }
}

