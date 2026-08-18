using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Polymorphism.Method_Overloading
{
    public static class Calc_Static
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        //public static int add(int b, int a)
        //{
        //    return b + a;
        //}

        public static int add(int x, int y, int z)
        {
            return x + y + z;
        }

        public static void Show(int x, string y)
        {
            string s = x + y;

            Console.WriteLine("The Result Shows", s);
        }

        public static void Show(string x, int y)
        {
            string s = x + y;
            Console.WriteLine("The Result Shows", s);
        }

        static void Main1(string[] args)
        {
            Console.WriteLine(Calc_Static.add(10, 20));
            Console.WriteLine(Calc_Static.add(10, 20, 30));

            /*
            Console.WriteLine(Calc_Static.Show(61258, " Pankaj S"));
            Console.WriteLine(Calc_Static.Show("Pankaj s", 61258));

            If the method is void , you cannot use it inside Console.WriteLine()...
            */

        }
    }
}