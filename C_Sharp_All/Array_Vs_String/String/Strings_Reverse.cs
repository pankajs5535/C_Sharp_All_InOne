using System;

namespace C_Sharp_All.Array_Vs_String.String
{
    class Strings_Reverse
    {
        static void Main1(string[] args)
        {
            string str = "Hello world";
            string revString = "";

            for (int i = str.Length - 1; i >= 0; --i)
            {
                revString += str[i];
            }

            Console.WriteLine(revString);
            Console.ReadLine();
        }
    }
}
