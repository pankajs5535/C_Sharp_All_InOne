using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Polymorphism.Method_Overriding.Stud_Teacher
{
    public class Person
    {
        // Fields
        protected string Name;
        protected int Age;

        // Constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Virtual method for overriding
        public virtual void PrintDetails()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Age: {Age}");
        }
    }

}
