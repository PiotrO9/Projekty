using Game2048.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class DeleteEmptyPlacesInLane
    {
        public static List<string> DeleteEmptyPlacesInLaneMethod(List<string> lane, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    {
                        for (int i = 0; i < lane.Count; i++)
                        {
                            if(lane[i] == "0")
                            {
                                lane.RemoveAt(i);
                                i = -1;
                            }
                        }

                        while(lane.Count < 4)
                        {
                            lane.Add("0");
                        }

                        return lane;
                    }
                case Direction.Down:
                    {
                        int iterator = 0;

                        for (int i = 0; i < lane.Count; i++)
                        {
                            if (lane[i] == "0")
                            {
                                lane.RemoveAt(i);
                                i = -1;
                                iterator++;
                            }
                        }

                        List<string> tempList = new List<string>();

                        for (int i = 0; i < iterator; i++)
                        {
                            tempList.Add("0");
                        }

                        for (int i = 0; i < lane.Count; i++)
                        {
                            tempList.Add(lane[i]);
                        }

                        lane = tempList;

                        return lane;
                    }
                case Direction.Left:
                    {
                        for (int i = 0; i < lane.Count; i++)
                        {
                            if (lane[i] == "0")
                            {
                                lane.RemoveAt(i);
                                i = -1;
                            }
                        }

                        while (lane.Count < 4)
                        {
                            lane.Add("0");
                        }

                        return lane;
                    }
                case Direction.Right:
                    {
                        int iterator = 0;

                        for (int i = 0; i < lane.Count; i++)
                        {
                            if (lane[i] == "0")
                            {
                                lane.RemoveAt(i);
                                i = -1;
                                iterator++;
                            }
                        }

                        List<string> tempList = new List<string>();

                        for (int i = 0; i < iterator; i++)
                        {
                            tempList.Add("0");
                        }

                        for (int i = 0; i < lane.Count; i++)
                        {
                            tempList.Add(lane[i]);
                        }

                        lane = tempList;

                        return lane;
                    }
            }

            return lane;
        }
    }
}
