using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Mobile_Demo
{
    // Main Class to Run the Program
    public class MobileMain
    {
        public static void Main1(string[] args)
        {
            Samsung s = new Samsung();
            s.SetMobile("Galaxy", "Samsung", "White", "12mp");
            s.GetMobile();
            System.Console.WriteLine("OS: " + s.os);

            System.Console.WriteLine("-----------------------------");

            Nokia n = new Nokia();
            n.SetMobile("Qwerty", "Nokia", "Red", "2mp");
            n.GetMobile();
            System.Console.WriteLine("OS: " + n.os);
        }
    }
}
