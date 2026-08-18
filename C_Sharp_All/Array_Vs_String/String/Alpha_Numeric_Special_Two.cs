using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Alpha_Numeric_Special_Two
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int specialCount = 0;
            int capitalCount = 0;
            int numberCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                // Check for special character
                if (!char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch))
                {
                    specialCount++;
                }

                // Check for capital letter
                if (char.IsUpper(ch))
                {
                    capitalCount++;
                }

                // Check for number
                if (char.IsDigit(ch))
                {
                    numberCount++;
                }
            }

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

            Console.ReadLine();
        }
    }
}