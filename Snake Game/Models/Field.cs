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
        public int X { get; set; }
        public int Y { get; set; }

        public Panel PanelField { get; private set; }

        public Field(int x, int y)
        {
            this.X = x;
            this.Y = y;

            this.PanelField = new Panel();
            {

            };
        }
    }
}
