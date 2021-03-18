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

            bool IfOtherActionExist = false;

            string temp = actionText;

            if (string.IsNullOrEmpty(actionText) == true)
            {
                return false;
            }
            else if (temp.Length < 2)
            {
                return false;
            }
            else
            {
                actionText = temp.Remove(0, 1);
            }

            foreach (var letter in actionText)
            {
                if (letter == '+' || letter == '*' || letter == '/')
                {
                    IfOtherActionExist = true; // True jeżeli działanie już wystąpiło
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

            int numberOfIndex = 1;

            for (int i = 0; i < actionText.Length; i++)
            {
                if (actionText[i] == '-')
                {
                    numberOfIndex = i;
                }
            }

            if (minusCounter > 0 && IfOtherActionExist == true)
            {
                return true;
            }
            else if (minusCounter == 0 && IfOtherActionExist == true)
            {
                return true;
            }
            else if (minusCounter == 1 && IfOtherActionExist == false)
            {
                return true;
            }


            if (actionText.Length > 2)
            {
                if ((actionText[numberOfIndex - 1] == '+' || actionText[numberOfIndex - 1] == '*' || actionText[numberOfIndex - 1] == '/') && (numberOfIndex > 0))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
