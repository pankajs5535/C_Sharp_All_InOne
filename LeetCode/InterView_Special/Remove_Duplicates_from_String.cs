using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    public class Remove_Duplicates_from_String
    {
        public static void Main1(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                bool found = false;

                // Check if character already exists in result
                for (int j = 0; j < result.Length; j++)
                {
                    if (s[i] == result[j])
                    {
                        found = true;
                        break;
                    }
                }

                // Add only unique character
                if (!found)
                {
                    result += s[i];
                }
            }

            Console.WriteLine("String after removing duplicates: " + result);
        }
    }
}