using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromDecimalToBinary.engines
{
     static class convert
    {
        public static string Method(int n)
        {
            string tempText = "";

            int temp = n;
            while (temp > 0)
            {
                if(temp%2 == 0)
                {
                    tempText += "0";
                }
                else
                {
                    tempText += "1";
                }

                temp = temp / 2;
            }

            string resultText = "";

            for (int i = tempText.Length; i > 0 ; i--)
            {
                resultText += tempText[i-1];
            }

            return resultText;
        }
    }
}
