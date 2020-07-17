using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_PPODST
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            string[] dane = new string[loops];

            for(int i=0;i<loops;i++)
            {
                dane[i] = Console.ReadLine();
            }

            float[] numbersInText = new float[loops];

            string cutting;

            for (int i = 0; i < loops; i++)
            {
                int length = dane[i].Length;
                string current = dane[i];

                if (current[length - 3] == ',')
                {
                    cutting = current.Remove(0, length - 4);
                    numbersInText[i] = float.Parse(cutting);
                }
                else if(current[length - 2] == ',')
                {
                    cutting = current.Remove(0, length - 3);
                    numbersInText[i] = float.Parse(cutting);
                }
                else 
                {
                    cutting = current.Remove(0, length - 1);
                    numbersInText[i] = float.Parse(cutting);
                }
            }

            float counting=0;

            for(int i=0;i<loops;i++)
            {
                counting += numbersInText[i];
            }

            Console.WriteLine(counting/loops);

            Console.ReadLine();
        }
    }
}
