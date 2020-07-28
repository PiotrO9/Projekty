using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class GeneratingMatrix
    {
        public static int[,] generatingMatrix(int sizeOfMatrix = 0)
        {
            if (sizeOfMatrix == 0)
            {
                sizeOfMatrix = InteractiveWithUser.GetIntFromUser("Wprowadź wielkość macierzy");
            }
            else if (sizeOfMatrix < 0)
            {
                while (sizeOfMatrix < 0)
                {
                    Console.WriteLine("Podana liczba jest za mała");
                    sizeOfMatrix = InteractiveWithUser.GetIntFromUser("Wprowadź wielkość macierzy");
                }
            }

            int[,] test = new int[sizeOfMatrix, sizeOfMatrix];

            return test;

        }
    }
}
