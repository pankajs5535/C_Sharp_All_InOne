using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    public class Sum_to_Target_Amount
    {
        static void Main1(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            // Take array input from user
            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < size; i++)
            {
                //Console.Write("Element " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Take target amount
            Console.Write("Enter target amount: ");
            int targetAmount = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            // Find two numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == targetAmount)
                    {
                        Console.WriteLine("\nNumbers are: " + numbers[i] + " and " + numbers[j]);
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
            if (!found)
            {
                Console.WriteLine("\nNo matching Pair found.");
            }

        }
    }
}