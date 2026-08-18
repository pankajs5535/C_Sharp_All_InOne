using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Polymorphism.Method_Overriding.Stud_Teacher
{
    public class Teacher : Person
    {
        // Fields
        public string Subject { get; set; }
        public int ExperienceYears { get; set; }

        // Constructor
        public Teacher(string name, int age, string subject, int experienceYears): base(name, age)  // Calling base class constructor
        {
            this.Subject = subject;
            this.ExperienceYears = experienceYears;
        }

        // Overriding the base class method
        public override void PrintDetails()
        {
            base.PrintDetails();  // Call base class method
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Experience Years: {ExperienceYears}");
        }
    }

}
