using Game2048.Engines.Engines_methods;
using Game2048.Enums;
using Game2048.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines
{
    class MoveEngine : IMoveEngine
    {
        public List<string> MovedList { get; set; }

        public MoveEngine(List<string> ListToMove, Direction direction)
        {
            if (ListToMove.Count != 16)
                throw new Exception("List count is invalid");

            if (direction == Direction.Up || direction == Direction.Down)
            {
                List<List<string>> PackedList = PackListToVertical(ListToMove);

                for (int i = 0; i < 4; i++)
                {
                    List<string> tempList = MoveEngineVerticaly(PackedList[i], direction);
                    PackedList[i] = DeleteEmptyPlacesInLane.DeleteEmptyPlacesInLaneMethod(tempList, direction);
                }

                MovedList = UnPackListToVertical(PackedList);
            }
            else
            {
                List<List<string>> PackedList = PackListToHorizontal(ListToMove);

                for (int i = 0; i < 4; i++)
                {
                    List<string> tempList = MoveEngineHorizontaly(PackedList[i], direction);
                    PackedList[i] = DeleteEmptyPlacesInLane.DeleteEmptyPlacesInLaneMethod(tempList, direction);
                }

                MovedList = UnPackListToHorizontal(PackedList);
            }


        }

        public List<string> MoveEngineVerticaly(List<string> lane, Direction direction)
        {
            if (CheckIfLaneIsFull.CheckIfLaneIsFullMethod(lane)) // If full
            {
                if (CheckIfLaneIsBlocked.CheckIfLaneIsBlockedMethod(lane)) // If blocked 
                    return lane;
                else
                {
                    if (CheckIfConnectingTwoTilesPossible.CheckIfConnectingTwoTilesPossibleMethod(lane)) // If connection possible
                    {
                        lane = ConnectTwoTiles.ConnectTwoTilesMethod(lane, direction);
                        return lane;
                    }
                    else
                        return lane;
                }
            }
            else
            {
                if (CheckIfConnectingTwoTilesPossible.CheckIfConnectingTwoTilesPossibleMethod(lane)) // If connection possible
                {
                    lane = ConnectTwoTiles.ConnectTwoTilesMethod(lane, direction);
                    return lane;
                }
                else
                    return lane;
            }

        }

        public List<string> MoveEngineHorizontaly(List<string> lane, Direction direction)
        {
            if (CheckIfLaneIsFull.CheckIfLaneIsFullMethod(lane)) // If full
            {
                if (CheckIfLaneIsBlocked.CheckIfLaneIsBlockedMethod(lane)) // If blocked 
                    return lane;
                else
                {
                    if (CheckIfConnectingTwoTilesPossible.CheckIfConnectingTwoTilesPossibleMethod(lane)) // If connection possible
                    {
                        lane = ConnectTwoTiles.ConnectTwoTilesMethod(lane, direction);
                        return lane;
                    }
                    else
                        return lane;
                }
            }
            else
            {
                if (CheckIfConnectingTwoTilesPossible.CheckIfConnectingTwoTilesPossibleMethod(lane)) // If connection possible
                {
                    lane = ConnectTwoTiles.ConnectTwoTilesMethod(lane, direction);
                    return lane;
                }
                else
                    return lane;
            }
        }

        private List<List<string>> PackListToVertical(List<string> ListToMove)
        {
            List<List<string>> result = new List<List<string>>();

            for (int i = 0; i < 4; i++)
            {
                result.Add(new List<string>());
                for (int j = 0; j < 4; j++)
                {
                    result[i].Add(ListToMove[j * 4 + i]);
                }
            }

            return result;
        }

        private List<List<string>> PackListToHorizontal(List<string> ListToMove)
        {
            List<List<string>> result = new List<List<string>>();

            for (int i = 0; i < 4; i++)
            {
                result.Add(new List<string>());
                for (int j = 0; j < 4; j++)
                {
                    result[i].Add(ListToMove[i * 4 + j]);
                }
            }

            return result;
        }

        private List<string> UnPackListToVertical(List<List<string>> ListToUnpack)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result.Add(ListToUnpack[j][i]);
                }
            }

            return result;
        }

        private List<string> UnPackListToHorizontal(List<List<string>> ListToUnpack)
        {
            List<string> result = new List<string>();

            foreach (var singleList in ListToUnpack)
            {
                for (int i = 0; i < 4; i++)
                {
                    result.Add(singleList[i]);
                }
            }

            return result;
        }
    }
}

