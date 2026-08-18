using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All.Array_Vs_String.Array
{
    internal class Copy_One_Into_Another_Array
    {
        static void Main6(string[] args)
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];

            int i, choice;

            Console.Write("\n\n Copy the elements one array into another array :\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write(" Input the number of elements to be stored in the array :");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array :\n", choice);

            for (i = 0; i < choice; i++)
            {
                Console.Write(" Element - {0} : ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n Copy elements of first array into second array");

            for (i = 0; i < choice; i++)
            {
                array2[i] = array1[i];
            }

            Console.Write("\n The elements stored in the first array are :\n");
            for (i = 0; i < choice; i++)
            {
                Console.Write(" {0}  ", array1[i]);
            }

            Console.Write("\n\n The elements copied into the second array are :\n");
            for (i = 0; i < choice; i++)
            {
                Console.Write(" {0}  ", array2[i]);
            }
            Console.Write("\n\n");
        }

    }
}
