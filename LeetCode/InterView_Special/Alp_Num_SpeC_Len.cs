using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.InterView_Special
{
    public class Alp_Num_SpeC_Len
    {
        public static void Main1(string[] args)
        {

            Console.WriteLine("Alp_Num_Spe_Length: ");

            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int special = 0, capital = 0, small = 0, number = 0;
            //int length = str.Length;   // string length
            int length = 0;

            foreach (char ch in str)
            {
                length++;

                if (ch >= 'A' && ch <= 'Z')
                {
                    capital++;
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    small++;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    number++;
                }
                else
                {
                    special++;
                }
            }

            Console.WriteLine("String Length: " + length);
            Console.WriteLine("Capital Letter Count: " + capital);
            Console.WriteLine("Small Letter Count: " + small);
            Console.WriteLine("Number Count: " + number);
            Console.WriteLine("Special Character Count: " + special);
        }

    }
}
