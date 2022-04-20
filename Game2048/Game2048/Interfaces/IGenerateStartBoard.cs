using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Interfaces
{
    public interface IGenerateStartBoard
    {
        List<string> OutputList { get; set; }
        List<string> GenerateStartBoardMethod(int minValue, int maxValue);
    }
}
