using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    abstract class klasa
    {
        public abstract void Metoda();

        public virtual void MetodaWirtualna()
        {
            Console.WriteLine("Niezmieniona metoda wirtualna");
        }

    }
}
