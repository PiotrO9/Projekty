using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    static class TextToList
    {
        public static List<string> method(string s)
        {
            var listOfWords = (s.Split(new char[] { '\r', '\n' },
                                                                StringSplitOptions.RemoveEmptyEntries)
                                                        ).ToList();

            return listOfWords;
        }

    }
}
