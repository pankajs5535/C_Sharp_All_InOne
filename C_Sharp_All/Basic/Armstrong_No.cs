using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Basic
{
    class Armstrong_No
    {
        static void Main1(String[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = number;
            int numDigits = number.ToString().Length;

            // Calculate the sum of the digits raised to the power of the number of digits
            while (temp > 0)
            {
                int currentDigit = temp % 10;
                sum += (int)Math.Pow(currentDigit, numDigits);
                temp /= 10;
            }

            // Check if the sum equals the original number
            if (sum == number)
                Console.WriteLine(number + " is an Armstrong number.");
            else
                Console.WriteLine(number + " is not an Armstrong number.");
            Console.ReadLine();
        }
    }
}
