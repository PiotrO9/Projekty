using Game2048.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Services
{
    class RangeRandomNumberService : IRandomRangeNumberService
    {
        public int RandomNumber { get; set; }
        
        public RangeRandomNumberService(int minValue, int maxValue)
        {
            if (minValue <= 0 || maxValue <= 0 || minValue >= maxValue)
                throw new Exception("Input numbers are invalid");

            RandomNumber = GenerateRandomRangeNumber(minValue, maxValue);
        }

        public int GenerateRandomRangeNumber(int minValue, int maxValue)
        {
            Random rnd = new Random();
            return rnd.Next(minValue, maxValue);
        }
    }
}
