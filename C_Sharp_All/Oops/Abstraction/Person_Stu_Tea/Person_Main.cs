using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Abstraction.Person_Stu_Tea
{
    abstract class Person
    {
        public string first_name;
        public string last_name;
        public int age;
        public long phone;
        public abstract void PrintDetails();        // Declare Abstract Method

    }

    class Student : Person
    {
        public int roll_no;
        public int fees;

        public override void PrintDetails()         //Must Declare Override Keyword
        {
            string name = this.first_name + "" + this.last_name;

            Console.WriteLine("\n Student Name is {0}", name);                      // {0} = This is Place Holder
            Console.WriteLine("\n Student Age is {0}", this.age);                   // {0} = This is Place Holder
            Console.WriteLine("\n Student Phone is {0}", this.phone);               // {0} = This is Place Holder
            Console.WriteLine("\n Student Roll NO is {0}", this.roll_no);           // {0} = This is Place Holder
            Console.WriteLine("\n Student Fees is {0}", this.fees);                 // {0} = This is Place Holder


        }
    }

    class Teacher : Person
    {
        public string qualification;
        public int salary;

        public override void PrintDetails() //Must Declare Override Keyword
        {
            string name = this.first_name + "" + this.last_name;

            Console.WriteLine("\n Teacher Name is {0}", name);                          // {0} = This is Place Holder
            Console.WriteLine("\n Teacher Age is {0}", this.age);                       // {0} = This is Place Holder
            Console.WriteLine("\n Teacher Phone is {0}", this.phone);                   // {0} = This is Place Holder
            Console.WriteLine("\n Teacher Qualification is {0}", this.qualification);   // {0} = This is Place Holder
            Console.WriteLine("\n Teacher salary is {0}", this.salary);                 // {0} = This is Place Holder


        }

    }

    class Person_Main
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("\n\n Abstract Class !");

            Console.WriteLine("\n\n Student Detail Class !");

            Student s = new Student();
            s.first_name = "Pankaj";
            s.last_name = "Suryawanshi";
            s.age = 50;
            s.phone = 9403249377;

            s.roll_no = 12;
            s.fees = 32500;

            s.PrintDetails();


            Console.WriteLine("\n\n ***************************************** !");


            Console.WriteLine("\n\n Teacher Detail Class !");

            Teacher t = new Teacher();
            t.first_name = "Internet";
            t.last_name = "Web";
            t.age = 10;
            t.phone = 602100;

            t.qualification = "Experience";
            t.salary = 50000000;

            t.PrintDetails();


            Console.ReadLine();
        }
    }
     
}


//Abstract Class's Object Not Created Directed in Main Method

//Use Abstract class member using its child classs Performing inheritance

//Avstract method doesnt have body

//Abstract Method must name Abstract 

//If abstract class not implemented in its child class then it automatically make abstract classs

//
