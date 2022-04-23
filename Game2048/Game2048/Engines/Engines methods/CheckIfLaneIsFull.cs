using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class CheckIfLaneIsFull
    {
        public static bool CheckIfLaneIsFullMethod(List<string> lane) // true if full, false when not full
        {
            foreach (var tile in lane)
            {
                if (tile == "0")
                    return false;
            }

            return true;
        }
    }
}
