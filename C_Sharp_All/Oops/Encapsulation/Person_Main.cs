using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace C_Sharp_All.Oops.Encapsulation
{
    class Person_Main
    {
        class Person
        {
            private int Age { get; set; }
            private string Name { get; set; }

            public void setName(string Name)
            {
                this.Name = Name;
            }

            public string getName()
            {
                return this.Name;
            }

            public void setAge(int Age)
            {
                this.Age = Age;
            }

            public int getAge()
            {
                return this.Age;
            }

        }
        static void Main1(string[] args)
        {
            Person p = new Person();
            p.setName("Doyal") ;
            p.setAge(30);

            Console.WriteLine("Name is "+p.getName());
            Console.WriteLine("Age is"+ p.getAge());


        }
    }
}
 