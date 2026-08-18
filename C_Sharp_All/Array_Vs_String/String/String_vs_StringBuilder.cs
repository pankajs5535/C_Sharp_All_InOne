using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Array_Vs_String.String
{
    internal class String_vs_StringBuilder
    {
        static void Main1(string[] args)
        {
            string str = "pankaj";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                str += i;
                //Console.WriteLine(str);

            }
            sw1.Stop();
            //Console.WriteLine(str);

            Console.WriteLine("------------------------------------");

            StringBuilder sb = new StringBuilder("Hello");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time Taken By String: " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time Taken By StringBuilder: " + sw2.ElapsedMilliseconds);



            Console.ReadLine();
        }
    }
}
