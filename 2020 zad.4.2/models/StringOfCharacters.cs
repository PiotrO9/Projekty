using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._4._2.models
{
    public class StringOfCharacters
    {
        public int length { get; set; }

        public string text { get; set; }

        public StringOfCharacters(string s, int n)
        {
            this.length = n;
            this.text = s;
        }
    }
}
