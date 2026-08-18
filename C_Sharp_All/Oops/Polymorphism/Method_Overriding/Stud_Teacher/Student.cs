using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Polymorphism.Method_Overriding.Stud_Teacher
{
    public class Student : Person
    {
        // Fields
        public string Grade { get; set; }
        public int StudentId { get; set; }

        // Constructor
        public Student(string name, int age, string grade, int studentId): base(name, age)  // Calling base class constructor
        {
            this.Grade = grade;
            this.StudentId = studentId;
        }

        // Overriding the base class method
        public override void PrintDetails()
        {
            base.PrintDetails();  // Call base class method
            System.Console.WriteLine($"Grade: {Grade}");
            System.Console.WriteLine($"Student ID: {StudentId}");
        }
    }

}
