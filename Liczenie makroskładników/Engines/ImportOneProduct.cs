using Liczenie_makroskładników.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    public static class ImportOneProduct
    {
        public static Product ImportSingleProduct(string s)
        {
            Product product = new Product();
            var ListOfComponents = s.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            product.Name = ListOfComponents[0];
            product.B = float.Parse(ListOfComponents[1]);
            product.T = float.Parse(ListOfComponents[2]);
            product.W = float.Parse(ListOfComponents[3]);
            product.Kcal = int.Parse(ListOfComponents[4]);
            product.Barcode = long.Parse(ListOfComponents[5]);

            return product;
        }
    }
}
