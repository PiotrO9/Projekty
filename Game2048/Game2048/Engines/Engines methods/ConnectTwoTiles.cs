using Game2048.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class ConnectTwoTiles
    {
        public static List<string> ConnectTwoTilesMethod(List<string> lane, Direction direction, int TypeOfMove)
        {

            switch (direction)
            {
                case Direction.Up:
                    {
                        switch (TypeOfMove)
                        {
                            case 0:
                                {
                                    for (int i = 0; i < 3; i++)
                                    {
                                        if (lane[i] == lane[i + 1])
                                        {
                                            lane[i] = (int.Parse(lane[i]) * 2).ToString();
                                            lane[i + 1] = "0";
                                        }
                                    }

                                    break;
                                }
                            case 1:
                                {
                                    lane[3] = (int.Parse(lane[3]) * 2).ToString();

                                    break;
                                }
                            case 2:
                                {
                                    lane[0] = (int.Parse(lane[1]) * 2).ToString();
                                    lane[1] = "0";
                                    lane[3] = "0";

                                    break;
                                }
                            case 3:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";
                                    lane[2] = "0";

                                    break;
                                }
                            case 4:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";

                                    break;
                                }
                            case 5:
                                {
                                    lane[2] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 6:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";
                                    lane[1] = lane[3];
                                    lane[3] = "0";
                                    break;
                                }
                            case 7:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 8:
                                {
                                    lane[0] = (int.Parse(lane[3]) * 2).ToString();
                                    lane[3] = "0";

                                    break;
                                }
                        }                       

                        break;
                    }
                case Direction.Down:
                    {
                        switch (TypeOfMove)
                        {
                            case 0:
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
                            case 1:
                                {
                                    lane[3] = (int.Parse(lane[3]) * 2).ToString();

                                    break;
                                }
                            case 2:
                                {
                                    lane[0] = (int.Parse(lane[1]) * 2).ToString();
                                    lane[1] = "0";
                                    lane[3] = "0";

                                    break;
                                }
                            case 3:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";
                                    lane[2] = "0";

                                    break;
                                }
                            case 4:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";

                                    break;
                                }
                            case 5:
                                {
                                    lane[2] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 6:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";
                                    lane[1] = lane[3];
                                    lane[3] = "0";
                                    break;
                                }
                            case 7:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 8:
                                {
                                    lane[0] = (int.Parse(lane[3]) * 2).ToString();
                                    lane[3] = "0";

                                    break;
                                }
                        }

                        break;
                    }
                case Direction.Left:
                    {
                        switch (TypeOfMove)
                        {
                            case 0:
                                {
                                    for (int i = 0; i < 3; i++)
                                    {
                                        if (lane[i] == lane[i + 1])
                                        {
                                            lane[i] = (int.Parse(lane[i]) * 2).ToString();
                                            lane[i + 1] = "0";
                                        }
                                    }

                                    break;
                                }
                            case 1:
                                {
                                    lane[3] = (int.Parse(lane[3]) * 2).ToString();

                                    break;
                                }
                            case 2:
                                {
                                    lane[0] = (int.Parse(lane[1]) * 2).ToString();
                                    lane[1] = "0";
                                    lane[3] = "0";

                                    break;
                                }
                            case 3:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";
                                    lane[2] = "0";

                                    break;
                                }
                            case 4:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";

                                    break;
                                }
                            case 5:
                                {
                                    lane[2] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 6:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";
                                    lane[1] = lane[3];
                                    lane[3] = "0";
                                    break;
                                }
                            case 7:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 8:
                                {
                                    lane[0] = (int.Parse(lane[3]) * 2).ToString();
                                    lane[3] = "0";

                                    break;
                                }
                        }

                        break;
                    }
                case Direction.Right:
                    {
                        switch (TypeOfMove)
                        {
                            case 0:
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
                            case 1:
                                {
                                    lane[3] = (int.Parse(lane[3]) * 2).ToString();

                                    break;
                                }
                            case 2:
                                {
                                    lane[0] = (int.Parse(lane[1]) * 2).ToString();
                                    lane[1] = "0";
                                    lane[3] = "0";

                                    break;
                                }
                            case 3:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";
                                    lane[2] = "0";

                                    break;
                                }
                            case 4:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";

                                    break;
                                }
                            case 5:
                                {
                                    lane[2] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 6:
                                {
                                    lane[0] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[2] = "0";
                                    lane[1] = lane[3];
                                    lane[3] = "0";
                                    break;
                                }
                            case 7:
                                {
                                    lane[3] = (int.Parse(lane[0]) * 2).ToString();
                                    lane[0] = "0";

                                    break;
                                }
                            case 8:
                                {
                                    lane[0] = (int.Parse(lane[3]) * 2).ToString();
                                    lane[3] = "0";

                                    break;
                                }
                        }

                        break;
                    }
            }

            return lane;
        }
    }
}
