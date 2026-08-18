using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Array_Vs_String.Array
{
    internal class Accessing_and_Declareation
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Array Declaration and Accesssing 1 !");

            int[] evenNum = new int[5];
            evenNum[0] = 5;
            evenNum[1] = 10;

            Console.WriteLine(evenNum[0]);

            Console.WriteLine(evenNum[1]);


            Console.WriteLine("-----------------------------------------------------------");


            Console.WriteLine("Array Declaration and Accesssing 2 !");

            int[] eve = new int[5] { 12, 14, 00, 60, 2100 };

            Console.WriteLine(eve[3]);

            Console.WriteLine(eve[4]);


            Console.WriteLine("***********************************************************");


            Console.WriteLine("Accesssing Array Element Using Loops!");

            int[] evenNums = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < evenNums.Length; i++)
            {
                Console.WriteLine("" + evenNums[i]);
            }


            Console.WriteLine("update the value of each element by 10");

            for (int i = 0; i < evenNums.Length; i++)
            {
                evenNums[i] = evenNums[i] + 10;

                Console.WriteLine("" + evenNums[i]);
            }

            Console.ReadLine();
        }

    }
}
