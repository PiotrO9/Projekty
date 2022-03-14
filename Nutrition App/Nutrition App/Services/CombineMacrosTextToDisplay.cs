using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services
{
    public static class CombineMacrosTextToDisplay
    {
        public static string CombineMacrosTextToDisplayMethod(int BValue, int TValue, int WValue)
        {
            string result = "Dodano następujące preferencje: ";
            result += BValue.ToString() + " B,";
            result += TValue.ToString() + " T,";
            result += WValue.ToString() + " W,";

            return result;
        }
    }
}
