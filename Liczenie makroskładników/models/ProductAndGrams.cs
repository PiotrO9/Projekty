using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.models
{
    public class ProductAndGrams
    {
        public Product product { get; set; }

        public int grams { get; set; }


        public ProductAndGrams(Product p)
        {
            this.product = p;
        }   

    }
}
