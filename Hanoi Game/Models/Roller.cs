using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Game.Models
{
    class Roller
    {
        public int size { get; private set; }

        public int number { get; private set; }

        public int fromWhichColumn { get; set; }

        public Roller(int s)
        {
            size = s;
            number = s;
        }
    }
}
