using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class CheckIfLaneIsBlocked
    {
        public static bool CheckIfLaneIsBlockedMethod(List<string> lane) // true if blocked, false is not blocked
        {
            for (int i = 0; i < 3; i++)
            {
                if (lane[i] == lane[i + 1])
                    return false;
            }

            return true;
        }
    }
}
