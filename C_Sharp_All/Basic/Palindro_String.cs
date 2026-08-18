using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Basic
{
    internal class Palindro_String
    {
        static void Main1(string[] args)
        {
            string original, reverse = "";

            Console.WriteLine("Enter a string or number");
            original = Console.ReadLine();

            int length = original.Length;

            // Reverse the string
            for (int i = length - 1; i >= 0; i--)
            {
                reverse = reverse + original[i];
            }

            // Compare string
            if (original.ToLower() == reverse.ToLower())
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.ReadLine();
        }
    }
}


/*
    Convert both strings to lowercase for case-insensitive comparison

    string originalLower = original.ToLower();
    string reverseLower = reverse.ToLower();

  Manually compare the strings

    if (originalLower == reverseLower)
    Console.WriteLine("Entered string or number is a palindrome");
    else
    Console.WriteLine("Entered string or number is a NOt palindrome");
         
*/


/*
namespace C_Sharp_All.Basic
{
    internal class Palindro_String
    {
        static void Main(string[] args)
        {
            string original, reverse = "";

            Console.WriteLine("Enter a string or number");
            original = Console.ReadLine();

            int length = original.Length;

            // Reverse the string
            for (int i = length - 1; i >= 0; i--) // abcdcba
            {
                reverse = reverse + original[i];

            }

            // Case-insensitive comparison
            if (original.Equals(reverse, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Entered string or number is a Palindrome");
            else
                Console.WriteLine("Entered string or number is a not Palindrome");


            Console.ReadLine();
        }
    }
}

*/