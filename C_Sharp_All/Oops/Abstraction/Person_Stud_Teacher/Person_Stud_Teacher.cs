using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Stud_Teacher
{
    public class Person_Main
    {
        public static void Main1(string[] args)
        {
            Teacher teacher = new Teacher("John Doe", 35, "Math", 10);
            Student student = new Student("Jane Smith", 17, 11, "S12345");

            teacher.PrintDetails();
            System.Console.WriteLine();
            student.PrintDetails();
        }
    }

}
