using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi_Game.Models
{
    class Roller
    {
        public Panel panel { get; set; }

        public int size { get; private set; }

        public int number { get; private set; }

        public int fromWhichColumn { get; set; }

        public Roller(int s)
        {
            size = s;
            number = s;

            this.panel = new Panel();


        }
    }
}
