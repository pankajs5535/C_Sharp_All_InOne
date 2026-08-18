using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    public class Move_Zeros_End
    {
        static void PushZerosToEnd(int[] arr)
        {
            int count = 0;

            // Move non-zero elements to front
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }

            // Fill remaining positions with zeros
            while (count < arr.Length)
            {
                arr[count] = 0;
                count++;
            }
        }

        public static void Main1(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Call method
            PushZerosToEnd(arr);

            Console.WriteLine("Array after moving zeros to end:");

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
