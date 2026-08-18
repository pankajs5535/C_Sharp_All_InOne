using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All.Array_Vs_String.Array
{
    internal class Sum_of_all_elementes_in_array
    {
        static void Main6(string[] args)
        {
            int[] arr = new int[50];
            int i, sum = 0, choice;


            Console.Write("\n\n Sum of all elements of array:\n");
            Console.Write("--------------------------------------\n");

            Console.Write("\n Enter the Choice store in Array: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array :\n", choice);

            for (i = 0; i < choice; i++)
            {
                Console.Write(" Element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < choice; i++)
            {
                sum = sum + arr[i];
            }


            Console.Write(" Sum of all elements stored in the array is : {0}\n\n", sum);
            Console.ReadLine();
        }

    }
}
