using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_OSTBR
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                string textInput = Console.ReadLine();

                int length = textInput.Length;

                Console.WriteLine(textInput[length - 1]);

            }

        }
    }
}
