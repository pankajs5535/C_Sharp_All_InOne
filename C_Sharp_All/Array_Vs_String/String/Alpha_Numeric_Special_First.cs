using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Alpha_Numeric_Special_First
    {
        static void Main(string[] args)
        {
            // Create a Scanner equivalent in C#

            Console.WriteLine("Alpha_Numeric_Special\r\n :");

            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int specialCount = 0, capitalCount = 0, numberCount = 0;

            // Loop through each character in the string
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                // Check for special characters
                if ((ch >= 32 && ch <= 47) || (ch >= 58 && ch <= 64) || (ch >= 91 && ch <= 96) || (ch >= 123 && ch <= 126))
                {
                    specialCount += 1;
                }
                // Check for capital letters
                if (ch >= 65 && ch <= 90)
                {
                    capitalCount += 1;
                }
                // Check for numbers
                if (ch >= 48 && ch <= 57)  // Corrected ASCII range for numbers
                {
                    numberCount += 1;
                }
            }

            // Output based on the counts
            if (specialCount == 0)
                Console.WriteLine("Special Character is Missing");
            else
                Console.WriteLine("Special Character is Available - Count: " + specialCount);

            if (capitalCount == 0)
                Console.WriteLine("Capital Letter is Missing");
            else
                Console.WriteLine("Capital Letter is Available - Count: " + capitalCount);

            if (numberCount == 0)
                Console.WriteLine("Number is Missing");
            else
                Console.WriteLine("Number is Available - Count: " + numberCount);

            // Hold the console window open
            Console.ReadLine();
        }
    }
}
