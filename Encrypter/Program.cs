using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string newText = Encrypter.Encrypt("Hola");
            Console.WriteLine("Text encripted: " + newText);
            string TextDescripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text descripted: " + TextDescripted);

            Console.ReadLine();
        }
    }
}
