using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class CheckIfConnectingTwoTilesPossible
    {
        public static bool CheckIfConnectingTwoTilesPossibleMethod(List<string> lane) // true if possible, false if not possible
        {
            for (int i = 0; i < 3; i++)
            {
                if (lane[i] == lane[i + 1] && lane[i] != "0")
                    return true;
            }

            return false;
        }
    }
}
