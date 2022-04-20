using Game2048.Interfaces;
using Game2048.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines
{
    public class GenerateStartBoard : IGenerateStartBoard
    {
        public List<string> OutputList { get; set; }

        public RandomRangeEvenNumberService randomRangeEvenNumberService { get; set; }

        public GenerateStartBoard(int minValue, int maxValue)
        {
            randomRangeEvenNumberService = new RandomRangeEvenNumberService(minValue, maxValue);
            OutputList = GenerateStartBoardMethod(minValue, maxValue);
        }

        public List<string> GenerateStartBoardMethod(int minValue, int maxValue)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < 16; i++)
            {
                result.Add(randomRangeEvenNumberService.RandomNumber.ToString());
            }

            return result;
        }
    }
}
