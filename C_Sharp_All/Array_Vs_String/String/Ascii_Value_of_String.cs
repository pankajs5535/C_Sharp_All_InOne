using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    public class Ascii_Value_of_String
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Ascii_Value_of_String :");

            Console.WriteLine("Enter the string :");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                bool alreadyChecked = false;

                // check duplicate
                for (int j = 0; j < i; j++)
                {
                    if (str[j] == str[i])
                    {
                        alreadyChecked = true;
                        break;
                    }
                }

                if (alreadyChecked)
                    continue;

                int asciiValue = str[i];

                Console.WriteLine(str[i] + " " + asciiValue);
            }
        }
    }
}



// Basic Program

/*

class Ascii_Value_of_String
{
    static void Main1(string[] args)
    {
        // Read string input from the user
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine("===========================================");

        // Printing ASCII values of each character
        foreach (char ch in str)
        {
            int asciiValue = ch;
            Console.WriteLine("Ascii value of " + ch + " is == " + asciiValue);
        }

        // Hold the console window open
        Console.ReadLine();
    }
}


*/