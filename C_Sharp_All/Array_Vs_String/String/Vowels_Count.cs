using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Vowels_Count
    {
        static void Main1(string[] args)
        {
            // Prompt user to enter a string
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int totalVowelCount = 0;
            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;

            // Loop through each character in the string
            for (int i = 0; i < str.Length; i++)
            {
                char ch = char.ToLower(str[i]); // Convert character to lowercase for case-insensitivity

                // Check if the character is a vowel and count accordingly
                if (ch == 'a')
                    aCount++;
                else if (ch == 'e')
                    eCount++;
                else if (ch == 'i')
                    iCount++;
                else if (ch == 'o')
                    oCount++;
                else if (ch == 'u')
                    uCount++;
            }

            // Calculate total vowel count
            totalVowelCount = aCount + eCount + iCount + oCount + uCount;

            // Output results
            if (totalVowelCount > 0)
            {
                Console.WriteLine("Vowels are present in the string.");
                Console.WriteLine("Total Vowels Count: " + totalVowelCount);
                Console.WriteLine("Count of 'a': " + aCount);
                Console.WriteLine("Count of 'e': " + eCount);
                Console.WriteLine("Count of 'i': " + iCount);
                Console.WriteLine("Count of 'o': " + oCount);
                Console.WriteLine("Count of 'u': " + uCount);
            }
            else
            {
                Console.WriteLine("No vowels found in the string.");
            }

            // Hold the console window open
            Console.ReadLine();
        }
    }
}


/*
 
using System;
using System.Collections.Generic;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Vowels_Count
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a string
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            // Initialize dictionary for vowel counts
            Dictionary<char, int> vowelCounts = new Dictionary<char, int>
            {
                {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}
            };

            int totalVowelCount = 0;

            // Loop through each character in the string
            foreach (char ch in str.ToLower()) // Convert to lowercase for case-insensitivity
            {
                // Check if the character is a vowel
                if (vowelCounts.ContainsKey(ch))
                {
                    vowelCounts[ch]++;
                    totalVowelCount++;
                }
            }

            // Output results
            if (totalVowelCount > 0)
            {
                Console.WriteLine("Vowels are present in the string.");
                Console.WriteLine("Total Vowels Count: " + totalVowelCount);

                // Print count for each vowel
                foreach (var kvp in vowelCounts)
                {
                    Console.WriteLine($"Count of '{kvp.Key}': {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("No vowels found in the string.");
            }

            // Hold the console window open
            Console.ReadLine();
        }
    }
}


*/