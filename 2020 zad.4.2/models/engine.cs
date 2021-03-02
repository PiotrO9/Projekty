using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._4._2.models
{
    public class engine
    {
        public StringOfCharacters Cut(string s)
        {
            int length = s.Length;

            int CharAmount = 0;

            char CurrentChar = ' ';

            for (int i = 0; i < length; i++)
            {
                if (CurrentChar == s[i])
                {
                    CharAmount += 1;
                }
                else
                {
                    CharAmount = 1;
                    CurrentChar = s[i];
                }

                if (CharAmount > length)
                {
                    length = CharAmount;
                }
            }

            string CharToString = CurrentChar.ToString();

            string ReadyString = "";

            for (int i = 0; i < CharAmount; i++)
            {
                ReadyString += CurrentChar.ToString();
            }

            StringOfCharacters stringOfCharacters = new StringOfCharacters(ReadyString, CharAmount);
            return stringOfCharacters;

        }
    }
}
