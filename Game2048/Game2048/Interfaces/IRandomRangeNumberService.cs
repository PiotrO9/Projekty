using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Interfaces
{
    public interface IRandomRangeNumberService
    {
        int RandomNumber { get; set; }

        int GenerateRandomRangeNumber(int minValue, int maxValue);
    }
}
