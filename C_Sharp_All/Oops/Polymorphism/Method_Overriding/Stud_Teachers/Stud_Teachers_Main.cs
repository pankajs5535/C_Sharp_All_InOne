using System;

namespace C_Sharp_All.Oops.Polymorphism.Method_Overriding.Stud_Teachers
{
    public class Persons
    {
        // Fields
        protected string Name;
        protected int Age;

        // Constructor
        public Persons(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Virtual method for overriding
        public virtual void PrintDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    public class Students : Persons
    {
        // Additional field
        private string School;

        // Constructor
        public Students(string name, int age, string school) : base(name, age)
        {
            this.School = school;
        }

        // Override method
        public override void PrintDetails()
        {
            base.PrintDetails(); // Call base class method
            Console.WriteLine("School: " + School);
        }
    }

    public class Teachers : Persons
    {
        // Additional field
        private string Subject;

        // Constructor
        public Teachers(string name, int age, string subject) : base(name, age)
        {
            this.Subject = subject;
        }

        // Override method
        public override void PrintDetails()
        {
            base.PrintDetails(); // Call base class method
            Console.WriteLine("Subject: " + Subject);
        }
    }

    public class Stud_Teachers_Main
    {
        public static void Main1(string[] args)
        {
            // Creating and displaying details for Persons class
            Console.WriteLine("Running: Persons class");

            Persons person = new Persons("Alice", 30);
            person.PrintDetails();
            Console.WriteLine();

            // Creating and displaying details for Students class
            Console.WriteLine("Running: Students class");
            Students student = new Students("Bob", 20, "XYZ University");
            student.PrintDetails();
            Console.WriteLine();

            // Creating and displaying details for Teachers class
            Console.WriteLine("Running: Teachers class");
            Teachers teacher = new Teachers("Charlie", 40, "Math");
            teacher.PrintDetails();

            Console.ReadLine();
        }
    }
}
