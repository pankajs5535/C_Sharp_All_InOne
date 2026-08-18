using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    public class First_non_Repeating
    {
        public static void Main1(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            int n = s.Length;
            char result = '$';

            for (int i = 0; i < n; ++i)
            {
                bool found = false;

                for (int j = 0; j < n; ++j)
                {
                    if (i != j && s[i] == s[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result = s[i];
                    break;
                }
            }

            Console.WriteLine("First Non-Repeating Character: " + result);
        }
    }
}