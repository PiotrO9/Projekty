using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.model
{
    class GameEngine
    {
        private readonly List<Cell> _listOfCells = new List<Cell>();

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
    }
}
