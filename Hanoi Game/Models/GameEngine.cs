using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Game.Models
{
    class GameEngine
    {
        public List<Roller> Column = new List<Roller>();

        private int amountOfRollers = 5;

        int LastClickedRoller = 1;

        public GameEngine()
        {
            for (int i = amountOfRollers; i > 0; i--)
            {
                Roller roller = new Roller(i);
                roller.fromWhichColumn = 1;
                Column.Add(roller);
            }
        }

        public GameEngine(int n)
        {
            //Roller roller = new Roller(0);
            //roller.fromWhichColumn = n;

            for (int i = amountOfRollers; i > 0; i--)
            {
                Roller roller = new Roller(i);
                roller.fromWhichColumn = 2;
                Column.Add(roller);
            }
        }


    }
}
