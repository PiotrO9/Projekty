using Game2048.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Services
{
    internal class RandomNumberService : IRandomNumberService
    {
        public int RandomNumber { get; set; }

        public RandomNumberService(int maxValue)
        {
            if (maxValue <= 0)
                throw new Exception("Intput number is invalid");

            RandomNumber = GenerateRandomNumber(maxValue);
        }

        public int GenerateRandomNumber(int maxValue)
        {
            Random rnd = new Random();

            return rnd.Next(0, maxValue);
        }
    }
}
