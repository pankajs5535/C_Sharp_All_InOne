using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Stud_Teacher
{
    public class Student : Person
    {
        // Properties for Grade and StudentId
        public int Grade { get; set; }
        public string StudentId { get; set; }

        // Constructor with parameters
        public Student(string name, int age, int grade, string studentId) : base(name, age)
        {
            Grade = grade; // ← calls set
            StudentId = studentId; // ← calls set
        }

        // Implementation of the abstract method
        public override void PrintDetails()
        {
            System.Console.WriteLine("Student Details:");
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Age: " + Age);
            System.Console.WriteLine("Grade: " + Grade); // ← calls get
            System.Console.WriteLine("Student ID: " + StudentId); // ← calls get
        }
    }

}
