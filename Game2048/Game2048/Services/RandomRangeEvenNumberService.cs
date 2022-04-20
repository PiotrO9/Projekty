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

            int[] library = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096 };

            foreach (var number in library)
            {
                if (number <= maxValue)
                {
                    temp++;
                }
                else
                {
                    break;
                }
            }

            int randomGeneratedNumebrOfLibraryIndex = rnd.Next(1, temp) - 1;

            return library[randomGeneratedNumebrOfLibraryIndex];
        }

    }
}
