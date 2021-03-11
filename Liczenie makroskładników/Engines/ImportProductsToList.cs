using Liczenie_makroskładników.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    public static class ImportProductsToList
    {
       public static List<Product> ImportProducts()
        {
            List<Product> Products = new List<Product>();

            string[] lines = File.ReadAllLines("Produkty.txt");

            foreach (var line in lines)
            {
                var item = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

                var newProduct = new Product();

                newProduct.Name = item[0];
                newProduct.B = float.Parse(item[1]);
                newProduct.T = float.Parse(item[2]);
                newProduct.W = float.Parse(item[3]);
                newProduct.Kcal = int.Parse(item[4]);
                newProduct.Barcode = long.Parse(item[5]);

                Products.Add(newProduct);
            }

            return Products;
        }
    }
}
