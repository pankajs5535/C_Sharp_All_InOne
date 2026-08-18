using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Inheritance
{
    public interface IPerson
    {
        void DisplayPersonalDetails();
    }

    public interface IEmployee
    {
        void DisplayEmployeeDetails();
    }

    public class Employee : IPerson, IEmployee
    {
        // Public fields instead of properties
        public string Name;
        public int EmployeeId;
        public string Department;

        public void DisplayPersonalDetails()
        {
            Console.WriteLine("Name: " + Name);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId + ", Department: " + Department);
        }
    }

    class Multiple
    {
        static void Main1(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "John Doe";
            employee.EmployeeId = 12345;
            employee.Department = "Software Development";

            employee.DisplayPersonalDetails();
            employee.DisplayEmployeeDetails();
        }
    }
}
