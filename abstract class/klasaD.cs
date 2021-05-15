using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
     class klasaD : klasa
    {
        public override void Metoda()
        {
            Console.WriteLine("Wypisanie metody abstrakcyjnej");
        }

        public override void MetodaWirtualna()
        {
            Console.WriteLine("Zmieniona metoda wirtualna");
        }
    }
}
