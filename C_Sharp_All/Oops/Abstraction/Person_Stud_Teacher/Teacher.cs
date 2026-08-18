using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Stud_Teacher
{
    public class Teacher : Person
    {
        // Properties for Subject and ExperienceYears
        public string Subject { get; set; }
        public int ExperienceYears { get; set; }

        // Constructor with parameters
        public Teacher(string name, int age, string subject, int experienceYears) : base(name, age)
        {
            Subject = subject; // ← calls set
            ExperienceYears = experienceYears; // ← calls set
        }

        // Implementation of the abstract method
        public override void PrintDetails()
        {
            System.Console.WriteLine("Teacher Details:");
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Age: " + Age);
            System.Console.WriteLine("Subject: " + Subject);    // ← calls get
            System.Console.WriteLine("Experience Years: " + ExperienceYears); // ← calls get
        }
    }

}
