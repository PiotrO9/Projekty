using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWPF.Engines
{
    public static class CheckIfAction
    {
        public static bool SearchAction(string actionText)
        {
            int minusCounter = 0;

            string temp = actionText;
            actionText = temp.Remove(actionText.Length - 1, 1);

            foreach (var letter in actionText)
            {
                if (letter == '+' || letter == '*' || letter == '/')
                {
                    return true; // True jeżeli działanie już wystąpiło
                }

                if (letter == '-')
                {
                    minusCounter++;
                }
            }

            if (minusCounter >= 2)
            {
                return true;
            }

            int numberOfIndex = 0;

            for (int i = 0; i < actionText.Length; i++)
            {
                if (actionText[i] == '-')
                {
                    numberOfIndex = i;
                }
            }

            if (actionText[numberOfIndex - 1] == '+' || actionText[numberOfIndex - 1] == '*' || actionText[numberOfIndex - 1] == '/')
            {
                return true;
            }



            return false;
        }
    }
}
