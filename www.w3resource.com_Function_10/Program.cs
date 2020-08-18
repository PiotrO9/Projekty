using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(ConvertAndCalculate(s));
            Console.ReadLine();
        }

        static int ConvertAndCalculate(string s)
        {
            int length = s.Length;

            int conv = int.Parse(s);

            string[] Array = new string[length];

            for (int i = 0; i < length; i++)
            {
                Array[i] = s[i].ToString();
            }

            int temp = 0;

            for (int i = 0; i < length; i++)
            {
                temp += int.Parse(Array[i]);
            }
            return temp;
        }
    }
}
