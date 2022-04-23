using Game2048.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Interfaces
{
    public interface IMoveEngine
    {
        List<string> MovedList { get; set; }
        List<string> MoveEngineVerticaly(List<string> setList, Direction direction);
        List<string> MoveEngineHorizontaly(List<string> setList, Direction direction);
    }
}
