using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Date_Emp
{
    public class Employee : Person
    {
        public int emp_id;
        public double salary;
        public double bonus;

        public Employee(int person_id, int dd, int mm, int yy, double sal, string profession)
            : base(person_id, dd, mm, yy, sal, profession)
        {
            this.salary = sal; // Assigning base salary
            this.bonus = 0; // Default bonus
        }

        public override void Display()
        {
            double totalSalary = CalculateSalary(); // Call CalculateSalary to get total salary
            System.Console.WriteLine($"Salary + Bonus: {totalSalary}");
            System.Console.Write($"Date of Joining: ");
            doj.ShowDate(); // Use ShowDate method to display date
        }

        public override double CalculateSalary()
        {
            return salary + bonus; // Return total salary including bonus
        }
    }

}
