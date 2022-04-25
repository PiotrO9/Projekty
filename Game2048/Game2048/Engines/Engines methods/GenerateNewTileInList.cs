using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines.Engines_methods
{
    public static class GenerateNewTileInList
    {
        public static List<string> GenerateNewTileInListMethod(List<string> result)
        {
            List<int> tempList = new List<int>();

            for (int i = 0; i < result.Count; i++)
            {
                if (String.Compare(result[i], "0") == 0)
                {
                    tempList.Add(i);
                }
            }

            Random rnd = new Random();
            int NumberToFillWithTwo = rnd.Next(0, tempList.Count - 1);
            result[tempList[NumberToFillWithTwo]] = "2";

            return result;
        }
    }
}
