using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Basic
{
    internal class Fibonacci
    {
        static void Main1(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;// 1
                second = next; // 1
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
