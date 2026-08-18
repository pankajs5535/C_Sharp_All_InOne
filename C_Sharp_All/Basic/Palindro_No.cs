using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Basic
{
    internal class Palindro_No
    {
        static void Main1(string[] args)
        {
            int remainder, sum = 0, temp;
            int no; // Declare n without initializing it

            Console.Write("Enter a number ");
            no = Convert.ToInt32(Console.ReadLine()); //12321
            int x = no;
            temp = no;
            while (no > 0)
            {
                remainder = no % 10;
                sum = (sum * 10) + remainder;
                no = no / 10;
            }

            // Compare the reversed number with the original number
            if (temp == sum)
                Console.WriteLine("The Given numner " + x + " is a Palindrome number");
            else
                Console.WriteLine("The Given numner " + x + " is Not a palindrome");

            Console.ReadLine();
        }
    }
}
