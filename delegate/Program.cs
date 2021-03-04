using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        public delegate void StringDelegate(string text);

        static void Main(string[] args)
        {
            StringDelegate stringDelegate = ToUpperCase;
            StringDelegate secoundStringDelegate = ToLowerCase;
            //stringDelegate("TesT TexT meSSage");

            stringDelegate += ToLowerCase;

            stringDelegate("TesT TexT meSSage");

            Console.ReadKey();
        }

        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());

        static void ToLowerCase(string text) => Console.WriteLine(text.ToLower().Remove(text.Length / 2));

        static void ToSplit(string text) => Console.WriteLine(text.Remove(text.Length / 2));
    }
}
