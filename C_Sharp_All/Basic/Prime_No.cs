using Oops_All.Array_Vs_String.Array;
using System;

namespace C_Sharp_All.Basic
{
    class Prime_No
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("\nPrime Numbers!");

            Console.Write("\nEnter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            int i, j, count;
            int primeCount = 0;  // Variable to count the number of prime numbers

            for (i = 2; i <= choice; i++)   // Loop from 2 up to the user's choice
            {
                count = 0;  // Reset count for each number

                for (j = 2; j < i; j++)  // Check if i is divisible by any number less than itself
                {
                    if (i % j == 0)
                    {
                        count++;  // Increment count, if i is divisible by j
                        break;    // No need to check further, i is not prime
                    }
                }

                if (count == 0)  // If count is still 0, then i is prime
                {
                    Console.WriteLine("Prime Number: " + i);
                    primeCount++;  // Increment the total prime count
                }
            }

            Console.WriteLine("\nTotal Prime Count: " + primeCount);

            Console.ReadLine();
        }
    }
}


// Another Option

/*
  
using System;


namespace C_Sharp_Object.Basic
{
    class Prime_No
    {
        static void Main(string[] args)
        {
            int i, j, count = 0;

            int choice = int.Parse(Console.ReadLine());

            for (i = 2; i < choice; i++)
            {
                bool isPrime = true;

                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine(i + " is prime");
            }
        }
    }
}


*/



/*
 
 Another Way : for (j = 2; j * j <= i; j++)

 */