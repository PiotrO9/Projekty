using Liczenie_makroskładników.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    static public class ProductToText
    {
        static public string ConvertProductIntoText(Product product)
        {
            string finalText = "";

            finalText += product.Name;
            finalText += ";";
            finalText += product.B.ToString();
            finalText += ";";
            finalText += product.T.ToString();
            finalText += ";";
            finalText += product.W.ToString();
            finalText += ";";
            finalText += product.Kcal.ToString();
            finalText += ";";
            finalText += product.Barcode.ToString();

            return finalText;
        }  
    }
}
