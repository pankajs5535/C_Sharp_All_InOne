using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All.Array_Vs_String.Array
{
    internal class A_Read_n_Display
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Array Read and Display !");
            Console.Write("-----------------------------\n");


            Console.WriteLine("Enter Your Choice For Print");
            int choice = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[choice];

            Console.WriteLine("Enter Element to Read");

            for (int i = 0; i < choice; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Array is ");

            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }

}

