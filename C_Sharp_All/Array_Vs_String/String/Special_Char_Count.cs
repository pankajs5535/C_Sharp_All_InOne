using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Special_Char_Count
    {
        static void Main1(string[] args)
        {
            // Create a Scanner equivalent in C#
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int count = 0;

            // Loop through each character in the string
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if ((ch >= 32 && ch <= 47) || (ch >= 58 && ch <= 64) || (ch >= 91 && ch <= 96) || (ch >= 123 && ch <= 126))
                {
                    count += 1;
                }
            }

            // Output the count of special characters
            Console.WriteLine("Number of special characters: " + count);
            Console.ReadLine();
        }
    }
}
