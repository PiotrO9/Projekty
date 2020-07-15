using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_RNO_DOD
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            int number1 = int.Parse(text1);
            int counting = 0;


            for (int i = 0; i < number1;i++)
            {
                string text2 = Console.ReadLine();
                int number2 = int.Parse(text2);

                string mainText = Console.ReadLine();
                string[] array1 = mainText.Split(' ');


                for(int j=0;j<number2;j++)
                {
                    int convertingNumber = int.Parse(array1[j]);
                    counting = counting + convertingNumber;
                }

                Console.WriteLine(counting);
                counting = 0;
            }
            Console.WriteLine("Koniec!");
            Console.ReadLine();
        }
    }
}
