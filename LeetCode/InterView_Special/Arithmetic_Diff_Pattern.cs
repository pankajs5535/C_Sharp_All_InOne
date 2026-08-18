using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    public class Arithmetic_Diff_Pattern
    {
        public static void Main1(string[] args)
        {
            int[] numbers = { 1, 3, 7, 13 };

            // Find last difference
            int lastDifference = numbers[numbers.Length - 1]
                               - numbers[numbers.Length - 2];

            // Increase difference by 2
            int nextDifference = lastDifference + 2;

            // Find next number
            int nextNumber = numbers[numbers.Length - 1] + nextDifference;

            Console.WriteLine("Next number is: " + nextNumber);
        }
    }
}