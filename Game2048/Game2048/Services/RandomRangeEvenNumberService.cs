using Game2048.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Services
{
    public class RandomRangeEvenNumberService : IRandomRangeNumberService
    {
        public int RandomNumber { get; set; }
        public RandomRangeEvenNumberService(int minValue, int maxValue)
        {
            if (minValue <= 0 || maxValue <= 0 || minValue >= maxValue)
            {
                if(maxValue - minValue <= 2)
                    throw new Exception("Input numbers are invalid");
            }

            RandomNumber = GenerateRandomRangeNumber(minValue, maxValue);
        }

        public int GenerateRandomRangeNumber(int minValue, int maxValue)
        {
            int temp = 0;
            Random rnd = new Random();

            do
            {
                temp = rnd.Next(minValue, maxValue);
            }
            while (temp % 2 == 0);

            return temp;
        }
    }
}
