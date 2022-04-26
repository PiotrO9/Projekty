using System;
using System.Collections.Generic;
using System.Text;

namespace Game2048.Engines
{
    public static class CalculateScoreBoard
    {
        public static int CalculateScoreBoardMethod(List<string> board)
        {
            int result = 0;

            for (int i = 0; i < board.Count; i++)
            {
                result += int.Parse(board[i]);
            }

            return result;
        }
    }
}
