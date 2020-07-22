using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int duplicated = 0;

            int[] inputElement = new int[loops];

            bool[] existingElement = new bool[loops];

            Console.WriteLine("--------------------");

            for (int i = 0; i < loops; i++)
            {
                inputElement[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < loops; i++)
            {
                if (existingElement[i] == true)
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < loops; j++)
                    {
                        if (i == j)
                            continue;
                        if (inputElement[i] == inputElement[j])
                        {
                            if (!existingElement[i])
                                duplicated += 1;
                            existingElement[i] = true;
                            existingElement[j] = true;
                        }
                    }
                }
            }

            Console.WriteLine("--------------------");

            Console.WriteLine(duplicated);

            Console.ReadLine();
        }
    }
}
