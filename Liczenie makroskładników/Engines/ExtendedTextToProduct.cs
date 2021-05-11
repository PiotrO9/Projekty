using Liczenie_makroskładników.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    public static class ExtendedTextToProduct
    {
        public static ProductAndGrams ExtendedTextToProductFunction(string s)
        {
            var listOfWords = (s.Split(new char[] { ';' }
                                                                )
                                                        ).ToList();

            if(listOfWords.Count != 7)
            {
                Product product = new Product();

                ProductAndGrams pag = new ProductAndGrams(product);

                return pag;
            }
            else
            {
                int grams;

                Product product = new Product();

                product.Name = listOfWords[0];
                grams = int.Parse(listOfWords[1]);
                product.B = float.Parse(listOfWords[2]);
                product.T = float.Parse(listOfWords[3]);
                product.W = float.Parse(listOfWords[4]);
                product.Kcal = (int)float.Parse(listOfWords[5]);
                product.Barcode = int.Parse(listOfWords[6]);

                ProductAndGrams pag = new ProductAndGrams(product);
                pag.grams = grams;

                return pag;
            }

        }
    }
}
