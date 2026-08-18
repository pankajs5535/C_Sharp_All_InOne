using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Inheritance
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class User : Entity
    {
        public string Name { get; set; }
    }

    public class AdminUser : User
    {
        public void GrantPermission()
        {
            Console.WriteLine($"{Name} (ID: {Id}) is granting permission.");
        }
    }

    class Multilevel
    {
        static void Main1(string[] args)
        {
            AdminUser admin = new AdminUser { Id = 1, Name = "John Doe" };
            admin.GrantPermission();
        }
    }

}
