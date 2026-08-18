using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Inheritance
{
    public interface IDevice
    {
        void Start();
    }

    public interface IPrinter : IDevice
    {
        void Print();
    }

    public class LaserPrinter : IPrinter
    {
        public void Start()
        {
            Console.WriteLine("Printer is starting...");
        }

        public void Print()
        {
            Console.WriteLine("Printing via Laser Printer...");
        }
    }

    class Interface_to_Interface
    {
        static void Main1(string[] args)
        {
            LaserPrinter printer = new LaserPrinter();
            printer.Start();
            printer.Print();
        }
    }
}
