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
            int d = 0;
            int p = 0;
            for (int i = 0; i < length;)
            {
                int j = i + 1;
                while (j < length && s[i] == s[j])
                {
                    j++;
                }
                if (d < j - 1)
                {
                    d = j - i;
                    p = i;
                }
                i = j;
            }

            string ReadyString = s.Substring(p, d);

            StringOfCharacters stringOfCharacters = new StringOfCharacters(ReadyString, d);
            return stringOfCharacters;

        }
    }
}
