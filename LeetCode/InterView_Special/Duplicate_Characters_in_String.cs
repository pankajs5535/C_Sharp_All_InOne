using System;

namespace LeetCode.InterView_Special
{
    public class Duplicate_Characters_in_String
    {
        public static void Main1(string[] args)
        {
            string s = "geeksforgeeks";

            // Convert string to char array
            char[] arr = s.ToCharArray();

            // Sorting without predefined function
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // Find duplicate characters
            for (int i = 0; i < arr.Length;)
            {
                int count = 1;

                while (i + count < arr.Length && arr[i] == arr[i + count])
                {
                    count++;
                }

                // Print duplicates only
                if (count > 1)
                {
                    Console.WriteLine(arr[i] + " = " + count);
                }

                i += count;
            }
        }
    }
}

//https://www.geeksforgeeks.org/dsa/print-all-the-duplicates-in-the-input-string/