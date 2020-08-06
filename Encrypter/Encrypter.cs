using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    class Encrypter
    {
        public static string Encrypt(string word)
        {
            int LetterInt = 0;
            char letter = ' ';
            string textEncripted = "";
            for (int i = 0; i < word.Length; i++)
            {
                LetterInt = (int)word[i] + 1;
                letter = (char)LetterInt;
                textEncripted += letter.ToString();
            }

            return textEncripted;
        }

        public static string Decrypt(string word)
        {
            int LetterInt = 0;
            char letter = ' ';
            string textEncripted = "";
            for (int i = 0; i < word.Length; i++)
            {
                LetterInt = (int)word[i] - 1;
                letter = (char)LetterInt;
                textEncripted += letter.ToString();
            }

            return textEncripted;
        }


    }
}
