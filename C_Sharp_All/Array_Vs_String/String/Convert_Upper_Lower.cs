using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Convert_Upper_Lower
    {
        static void Main1(string[] args)
        {
            // Read string input from the user
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("===========================================");

            // Converting uppercase to lowercase and lowercase to uppercase
            foreach (char ch in str)
            {
                if (ch >= 'A' && ch <= 'Z') // Uppercase letter
                {
                    char lower = (char)(ch + 32); // Convert to lowercase
                    Console.WriteLine(ch + "     " + lower);
                }
                else if (ch >= 'a' && ch <= 'z') // Lowercase letter
                {
                    char upper = (char)(ch - 32); // Convert to uppercase
                    Console.WriteLine(ch + "     " + upper);
                }
                else // Special characters
                {
                    Console.Write(ch); // Just print special characters as they are
                }
            }

            // Hold the console window open
            Console.ReadLine();
        }
    }
}
