using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    public class Swap_Two_Numbers
    {
        public static void Main1(string[] args)
        {
            Console.Write("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore Swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Swapping without third variable
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}