using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_zad._5._2.models
{
    public class Dates
    {
        public int firstDate { get; set; }

        public int LastDate { get; set; }

        public Dates(int f, int l)
        {
            this.firstDate = f;
            this.LastDate = l;
        }

    }
}
