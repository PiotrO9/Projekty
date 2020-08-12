using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Game.Models
{

    class GameEngine
    {
        public List<Roller> firstcollumn = new List<Roller>();
        public List<Roller> secoundcollumn = new List<Roller>();
        public List<Roller> thirdcollumn = new List<Roller>();

        int amountOfRollers = 3;

        public GameEngine()
        {
            for (int i = amountOfRollers; i > 0; i--)
            {
                Roller roller = new Roller(i);
                firstcollumn.Add(roller);
            }
        }

        public void DisplayFirstCollumn()
        {
            if (firstcollumn.Count == 3)
            {

            }
        }
    }
}
