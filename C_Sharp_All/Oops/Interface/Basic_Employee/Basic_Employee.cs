using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Interface.Basic_Employee
{

    interface IEmployee
    {
        void Show(); // by defaultthis is public you cant give this public 
    }

    class Basic_Employee : IEmployee
    {
        public void Show()
        {
            Console.WriteLine("This is method of Employee interface");
        }
    }

    class MainEmployee
    {
        static void Main1(string[] args)
        {
            Basic_Employee b = new Basic_Employee();
            b.Show();
            Console.ReadLine();

        }
    }
}


/*
 
class B
{
    public void Show()
    {
        Console.WriteLine("Method from B");
    }
}

// This is NOT allowed in C#
class C : A, B
{
}

class Program
{
    static void Main()
    {
        C obj = new C();
        obj.Show(); 
    }
}
 */