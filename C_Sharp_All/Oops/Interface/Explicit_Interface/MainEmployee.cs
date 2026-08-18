using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Interface.Explicit_Interface
{

    interface I1
    {
        void Show();
    }

    interface I2
    {
        void Show();
    }


    class Basic_Employee:I1,I2 
    {
        void I1.Show()
        {
            Console.WriteLine("This method is from interface I1");
        }

        void I2.Show()
        {
            Console.WriteLine("This method is from Interface I2");
        }

    }

    class MainEmployee
    {
        static void Main1(string[] args)
        {
            Basic_Employee emp = new Basic_Employee();
            //emp.Show(); // cant create object beacause its explict interface 

            ((I1)emp).Show(); // Instead, this is explicit type casting — specifically, interface casting.
            ((I2)emp).Show();// Instead, this is explicit type casting — specifically, interface casting.

            //parents reference variable can acaquaire child variable
            //this is below another way to call interface method 
            // first parent object reference is equal to child object

            I1 obj1=new Basic_Employee();
            obj1.Show();

            I2 obj2= new Basic_Employee();
            obj2.Show();

        }

    }
}
