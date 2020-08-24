using System;
using System.Collections.Generic;
using System.Drawing;
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

        public bool Active = false;

        public PictureBox Picture { get; set; }

        private TypeOfField _type;

        public TypeOfField Type
        {
            get { return _type; }

            set
            {
                _type = value;
                switch (value)
                {
                    case TypeOfField.none:
                        this.Picture.BackColor = Color.FromArgb(0, 127, 255);
                        break;
                    case TypeOfField.redField:
                        this.Picture.BackColor = Color.FromArgb(255, 0, 0);
                        break;
                    case TypeOfField.blueField:
                        this.Picture.BackColor = Color.FromArgb(0, 0, 255);
                        break;
                    case TypeOfField.greenField:
                        this.Picture.BackColor = Color.FromArgb(0, 255, 0);
                        break;
                    case TypeOfField.yellowField:
                        this.Picture.BackColor = Color.FromArgb(255, 255, 0);
                        break;
                    case TypeOfField.orangeField:
                        this.Picture.BackColor = Color.FromArgb(255, 165, 0);
                        break;
                    default:
                        break;
                }
                ;
            }
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
