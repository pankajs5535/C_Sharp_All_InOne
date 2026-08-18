using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Date_Emp
{
    public class Person_Employee
    {
        public static void Main1(string[] args)
        {
            Employee e = new Employee(10, 11, 3, 2023, 176588, "Pankaj");
            e.bonus = 10000; // Setting a bonus for the employee
            e.Display();
        }
    }

}
