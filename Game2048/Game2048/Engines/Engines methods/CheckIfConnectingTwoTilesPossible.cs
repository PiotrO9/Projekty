using Game2048.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class CheckIfConnectingTwoTilesPossible
    {
        public static int CheckIfConnectingTwoTilesPossibleMethod(List<string> lane, Direction direction) // true if possible, false if not possible
        {
            for (int i = 0; i < 3; i++)
            {
                if (lane[i] == lane[i + 1] && lane[i] != "0")
                    return 0;
            }

            if((lane[1] == lane[3] && lane[1] != "0") && (lane[0] == lane[2] && lane[0] == "0") && (direction == Direction.Right || direction == Direction.Down))
                return 1;

            if ((lane[1] == lane[3] && lane[1] != "0") && (lane[0] == lane[2] && lane[0] == "0") && (direction == Direction.Left || direction == Direction.Up))
                return 2;

            if ((lane[0] == lane[2] && lane[0] != "0") && (lane[1] == lane[3] && lane[1] == "0") && (direction == Direction.Right || direction == Direction.Down))
                return 3;

            if ((lane[0] == lane[2] && lane[0] != "0") && (lane[1] == lane[3] && lane[1] == "0") && (direction == Direction.Left || direction == Direction.Up))
                return 4;

            if ((lane[0] == lane[2] && lane[0] != "0") && (lane[1] == "0") && (direction == Direction.Right || direction == Direction.Down) && (lane[3] != "0" && lane[3] != lane[1]))
                return 5;

            if ((lane[0] == lane[2] && lane[0] != "0") && (lane[1] == "0") && (direction == Direction.Right || direction == Direction.Down) && (lane[3] != "0" && lane[3] != lane[1]))
                return 6;

            if (lane[0] == lane[3] && lane[0] != "0" && lane[1] == lane[2] && lane[1] == "0" && (direction == Direction.Right || direction == Direction.Down))
                return 7;

            if (lane[0] == lane[3] && lane[0] != "0" && lane[1] == lane[2] && lane[1] == "0" && (direction == Direction.Left || direction == Direction.Up))
                return 8;

            return -1;
        }
    }
}
