using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.models
{
    public class Product
    {
        //Dane liczone na 100g produktu

        public string Name { get; set; }
        public float B { get; set; }
        public float T { get; set; }
        public float W { get; set; }
        public int Kcal { get; set; }
        public long Barcode { get; set; }
    }
}
