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

        private void Cell_CellClicked(object sender, CellEventArgs e)
        {

        }

        public void Clear()
        {
            _listOfCells.ForEach(cell => cell.Clear());
        }

        public void UserClickedNumber(int n)
        {
            var activCell = this._listOfCells.Where(w => w.Active);
        }

        public void AddingValues()
        {
            Random rnd = new Random();
            foreach (var item in _listOfCells)
            {
                int rn = rnd.Next(1, 10);

                IEnumerable<Cell> queryI = _listOfCells.Where(_listOfCells => _listOfCells.X == item.X);
                IEnumerable<Cell> queryJ = _listOfCells.Where(_listOfCells => _listOfCells.Y == item.Y);

                item.GeneratedValue = rn;

                foreach (var itemI in queryI)
                {
                    if (item.Y == itemI.Y)
                    {
                        continue;
                    }
                    else if (item.GeneratedValue == itemI.GeneratedValue)
                    {
                        while (item.GeneratedValue == itemI.GeneratedValue)
                        {
                            rn = rnd.Next(1, 10);
                            item.GeneratedValue = rn;
                        }
                    }

                    item.ButtonCell.Text = item.GeneratedValue.ToString();
                }

                foreach (var itemJ in queryJ)
                {
                    if (item.X == itemJ.X)
                    {
                        continue;
                    }
                    else if (item.GeneratedValue == itemJ.GeneratedValue)
                    {
                        while (item.GeneratedValue == itemJ.GeneratedValue)
                        {
                            rn = rnd.Next(1, 10);
                            item.GeneratedValue = rn;
                        }
                    }

                    item.ButtonCell.Text = item.GeneratedValue.ToString();
                }


                ///////////////////////////////////////////////////////////////////////////////////////////////

                //    int rn = rnd.Next(1, 10);

                //    IEnumerable<Cell> queryI = _listOfCells.Where(_listOfCells => _listOfCells.X == item.X);
                //    IEnumerable<Cell> queryJ = _listOfCells.Where(_listOfCells => _listOfCells.Y == item.Y);

                //    item.GeneratedValue = rnd.Next(1, 10);

                //    foreach (var itemI in queryI)
                //    {

                //        if (itemI.X == item.X)
                //        {
                //            continue;
                //        }

                //        if (itemI.GeneratedValue == item.GeneratedValue && itemI.GeneratedValue != 0)
                //        {
                //            while (itemI.GeneratedValue == item.GeneratedValue)
                //            {
                //                item.GeneratedValue = rnd.Next(1, 10);
                //            }
                //        }
                //        else
                //        {
                //            continue;
                //        }

                //        item.ButtonCell.Text = item.GeneratedValue.ToString();
                //    }

                //    foreach (var itemJ in queryJ)
                //    {
                //        itemJ.GeneratedValue = rnd.Next(1, 10);

                //        if (itemJ.Y == item.Y)
                //        {
                //            continue;
                //        }

                //        if (itemJ.GeneratedValue == item.GeneratedValue && itemJ.GeneratedValue != 0)
                //        {
                //            while (itemJ.GeneratedValue == item.GeneratedValue)
                //            {
                //                item.GeneratedValue = rnd.Next(1, 10);
                //            }
                //        }
                //        else
                //        {
                //            continue;
                //        }

                //        item.ButtonCell.Text = item.GeneratedValue.ToString();
                //    }
                //}

                /////////////////////////////////////////////////////////////////////////////////////////////////////

                //foreach (var item in _listOfCells)
                //{
                //    Random rnd = new Random();
                //    int rn = rnd.Next(1, 10);

                //    IEnumerable<Cell> queryI = _listOfCells.Where(_listOfCells => _listOfCells.X == item.X);

                //    foreach (var elementI in queryI)
                //    {
                //        if (elementI.X == item.X)
                //        {
                //            break;
                //        }

                //        if (elementI.GeneratedValue == rn)
                //        {
                //            while (elementI.GeneratedValue != rn)
                //            {
                //                rn = rnd.Next(1, 10);
                //            }
                //        }
                //        else
                //        {
                //            item.GeneratedValue = rn;
                //        }
                //    }

                //    IEnumerable<Cell> queryJ = _listOfCells.Where(_listOfCells => _listOfCells.Y == item.Y);

                //    foreach (var elementJ in queryI)
                //    {
                //        if (elementJ.Y == item.Y)
                //        {
                //            break;
                //        }

                //        if (elementJ.GeneratedValue == rn)
                //        {
                //            while (elementJ.GeneratedValue != rn)
                //            {
                //                rn = rnd.Next(1, 10);
                //            }
                //        }
                //        else
                //        {
                //            item.GeneratedValue = rn;
                //        }
                //    }

                //    item.ButtonCell.Text = item.GeneratedValue.ToString();
                //}
            }
        }


        public void putValueInButtons(int number)
        {
            IEnumerable<Cell> query = _listOfCells.Where(_listOfCells => _listOfCells.Active == true);

            foreach (var item in query)
            {
                item.ButtonCell.Text = number.ToString();
                item.UserValue = number;
                if (item.UserValue == item.GeneratedValue)
                {
                    item.ButtonCell.BackColor = Color.Red;
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

    }
}

