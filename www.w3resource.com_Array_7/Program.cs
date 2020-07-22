using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayFromUser = InteractiveWithUser.GetIntArray();
            int[] secoundArrayFromUser = InteractiveWithUser.GetIntArray();

            int totalArrayLength = firstArrayFromUser.Length + secoundArrayFromUser.Length;
            int[] thirdArrayFromUser = new int[totalArrayLength];

            for (int i = 0; i < totalArrayLength; i++)
            {
                if (i < firstArrayFromUser.Length)
                {
                    thirdArrayFromUser[i] = firstArrayFromUser[i];
                }
                else if (i >= firstArrayFromUser.Length)
                {
                    thirdArrayFromUser[i] = secoundArrayFromUser[i - firstArrayFromUser.Length];
                }
            }

            Console.WriteLine("--------------");

            for (int i = 0; i < thirdArrayFromUser.Length; i++)
            {
                Console.Write(thirdArrayFromUser[i] + " ");
            }

            Array.Sort(thirdArrayFromUser);

            Console.Write("\n");

            for (int i = 0; i < thirdArrayFromUser.Length; i++)
            {
                Console.Write(thirdArrayFromUser[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
