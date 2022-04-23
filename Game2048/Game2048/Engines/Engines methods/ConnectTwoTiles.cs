using Game2048.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class ConnectTwoTiles
    {
        public static List<string> ConnectTwoTilesMethod(List<string> lane, Direction direction)
        {

            switch (direction)
            {
                case Direction.Up:
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (lane[i] == lane[i + 1])
                            {
                                lane[i] = (int.Parse(lane[i]) * 2).ToString();
                                lane[i + 1] = "0";
                            }
                        }

                        break;
                    }
                case Direction.Down:
                    {
                        for (int i = 3; i > 0; i--)
                        {
                            if (lane[i] == lane[i - 1])
                            {
                                lane[i] = (int.Parse(lane[i]) * 2).ToString();
                                lane[i - 1] = "0";
                            }
                        }
                    break;
                    }
                case Direction.Left:
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (lane[i] == lane[i + 1])
                            {
                                lane[i] = (int.Parse(lane[i]) * 2).ToString();
                                lane[i + 1] = "0";
                            }
                        }
                    break;
                    }
                case Direction.Right:
                    {
                        for (int i = 3; i > 0; i--)
                        {
                            if (lane[i] == lane[i - 1])
                            {
                                lane[i] = (int.Parse(lane[i]) * 2).ToString();
                                lane[i - 1] = "0";
                            }
                        }
                    break;
                    }
            }

            return lane;
        }
    }
}
