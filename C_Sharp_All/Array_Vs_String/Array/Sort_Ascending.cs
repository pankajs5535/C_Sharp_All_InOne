using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All.Array_Vs_String.Array
{
    internal class Sort_Ascending
    {
        static void Main3(string[] args)
        {
            int[] arr = new int[10];
            int choice, i, j, temp;

            Console.Write("\n\n Sort elements of array in ascending order :\n");
            Console.Write("---------------------------------------------------\n");

            Console.Write(" Input the size of array : ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array :\n", choice);
            for (i = 0; i < choice; i++)
            {
                Console.Write(" Element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < choice; i++)
            {
                for (j = i + 1; j < choice; j++)
                {
                    //if (arr[i] > arr[j])
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("\n Elements of array in sorted ascending order:\n");
            for (i = 0; i < choice; i++)
            {
                Console.Write(" {0}  ", arr[i]);
            }
            Console.ReadLine();

        }

    }
}
