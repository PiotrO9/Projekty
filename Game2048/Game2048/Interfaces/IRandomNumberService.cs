using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Interfaces
{
    internal interface IRandomNumberService
    {
        int RandomNumber { get; set; }

        int GenerateRandomNumber(int maxValue);
    }
}
