using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Polymorphism.Method_Overriding.Stud_Teacher
{
    using System;
    public class Stud_Techer_Main
    {
        public static void Main1(string[] args)
        {
            // Creating objects
            Person person = new Person("John", 30);
            Teacher teacher = new Teacher("Alice", 45, "Math", 15);
            Student student = new Student("Bob", 20, "A", 12345);

            // Displaying details for each object
            Console.WriteLine("Person Details:");
            person.PrintDetails();

            Console.WriteLine("\nTeacher Details:");
            teacher.PrintDetails();

            Console.WriteLine("\nStudent Details:");
            student.PrintDetails();
        }
    }
 

}
