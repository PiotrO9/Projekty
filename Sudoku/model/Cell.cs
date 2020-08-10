using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.model
{
    class Cell
    {
        public Button ButtonCell { get; private set; }

        public event EventHandler<CellEventArgs> CellClicked;

        public int X { get; private set; }
        public int Y { get; private set; }

        public int GeneratedValue { get; set; }

        public int UserValue { get; set; }

        public bool Active { get; set; }

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Active = false;
            this.GeneratedValue = 0;

            this.ButtonCell = new Button()
            {
                Name = $"btn{x}{y}",
                Text = $"{x}{y}",
                Height = 50,
                Width = 50,
            };

            this.ButtonCell.Click += ButtonCell_Click;
        }

        private void ButtonCell_Click(object sender, EventArgs e)
        {
            this.CellClicked?.Invoke(this, new CellEventArgs() { X = this.X, Y = this.Y });
            this.Active = true;
        }

        public void Clear()
        {
            this.GeneratedValue = 0;
            this.UserValue = 0;
            this.ButtonCell.Text = string.Empty;
        }
    }
}
