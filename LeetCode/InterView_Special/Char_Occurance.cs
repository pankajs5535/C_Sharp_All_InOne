using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.InterView_Special
{
    internal class Char_Occurance
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Char_Occurance");

            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                bool alreadyChecked = false;

                // Check if character already counted
                for (int j = 0; j < i; j++) // j from start to end of string and == i have only one charactor
                {
                    if (str[j] == str[i]) // match found / CHeck duplicate charactor
                    {
                        alreadyChecked = true;
                        break;
                    }
                }
                // If already counted, skip this character
                if (alreadyChecked)
                    continue;

                // Count occurrences of current character in whole string
                for (int k = 0; k < str.Length; k++)
                {
                    if (str[i] == str[k]) // compare with every character then count
                    {
                        count++;
                    }
                }

                Console.WriteLine("Occurrence of " + str[i] + " : " + count);
            }

            Console.ReadLine();
        }
    }
}



/*
  

Loop	    Purpose
i	        pick character
j	        check duplicate
k	        count occurrences

j loop      → checks duplicate (skip work)
k loop      → counts occurrences

 */