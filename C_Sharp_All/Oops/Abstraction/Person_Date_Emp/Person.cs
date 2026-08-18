using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Date_Emp
{
    public abstract class Person
    {
        protected int person_id;
        protected Date doj;
        protected double sal;
        protected string profession = "Developer";

        public Person(int person_id, int dd, int mm, int yy, double sal, string profession)
        {
            this.person_id = person_id;
            this.doj = new Date(dd, mm, yy);
            this.sal = sal;
            this.profession = profession;
        }

        public abstract void Display();

        public abstract double CalculateSalary(); // Changed return type to double
    }


}
