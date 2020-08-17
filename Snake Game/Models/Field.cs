using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game.Models
{
    class Field
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private TypeOfField _type;
        public TypeOfField Type
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (value)
                {
                    case TypeOfField.None:
                        this.PictureField.BackColor = Color.FromArgb(0, 0, 0);
                        break;
                    case TypeOfField.Snake:
                        this.PictureField.BackColor = Color.FromArgb(124, 252, 0);
                        break;
                    case TypeOfField.Food:
                        this.PictureField.BackColor = Color.FromArgb(255, 0, 0);
                        break;
                    default:
                        break;
                }
            }
        }

        public PictureBox PictureField { get; private set; }

        public Field(int x, int y)
        {
            this.X = x;
            this.Y = y;

            this.PictureField = new PictureBox()
            {
                Name = $"Picture{x}{y}",
                // BackColor = Color.FromArgb(255, 0, 0),

            };
        }
    }
}
