using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Stud_Teacher
{
    public abstract class Person
    {
        // Properties for Name and Age
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor
        public Person() { }

        // Constructor with parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Abstract method to print details
        public abstract void PrintDetails();
    }

}
