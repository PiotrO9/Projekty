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
            OutputList = GenerateStartBoardMethod(minValue, maxValue);
        }

        public List<string> GenerateStartBoardMethod(int minValue, int maxValue)
        {
            List<string> result = new List<string>();

            Random rnd = new Random();
            int temp = rnd.Next(0, 15);

            for (int i = 0; i < 16; i++)
            {
                if(i == temp)
                {
                    randomRangeEvenNumberService = new RandomRangeEvenNumberService(minValue, maxValue);
                    result.Add(randomRangeEvenNumberService.RandomNumber.ToString());
                }
                else
                {
                    result.Add("0");
                }
            }

            return result;
        }
    }
}
