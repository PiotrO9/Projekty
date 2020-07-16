using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_PA05_POT_potegi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNumberLoops = Console.ReadLine();

            int numberLoops = int.Parse(sNumberLoops);

            for(int i=0;i<numberLoops;i++)
            {
                string textInput = Console.ReadLine();
                int length1 = textInput.Length;
                string textCountingLength = textInput.Replace(" ", "");
                int length2 = textCountingLength.Length;


                int lengthSpaces = length1 - length2;

                string[] array1 = textInput.Split();

                int first = int.Parse(array1[0]);
                int secound = int.Parse(array1[1]);

                int multiplication = first;

                for (int j=0;j<secound-1;j++)
                {
                    multiplication = multiplication * first;
                }

                Console.WriteLine(multiplication);
                int length = multiplication.ToString().Length;
                string score = multiplication.ToString();

                Console.WriteLine(score[length - 1]);
                
            }
            Console.ReadLine();

        }
    }
}
