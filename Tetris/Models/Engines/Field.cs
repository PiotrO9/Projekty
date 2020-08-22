using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris.Models.Enums
{
    class Field
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TypeOfField Type { get; set; }

        public PictureBox Picture { get; set; }

        private TypeOfField _type;

        public int MyProperty
        {
            get;

            set;
        }

        public Field(int x, int y)
        {
            this.X = x;
            this.Y = y;

            this.Picture = new PictureBox()
            {
                Name = $"Picture{x}{y}",
                Margin = new Padding(0, 0, 0, 0),
            };
        }
    }
}
