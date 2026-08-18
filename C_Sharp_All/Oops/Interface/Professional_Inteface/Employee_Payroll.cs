using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Interface.Professional_Inteface
{
    using System;
    using System.Collections.Generic;

    namespace ProfessionalIMS
    {
        // ---------------- Interfaces ----------------
        public interface IEmployee
        {
            string FullName { get; }
            void PerformDuty();
        }

        public interface IDepartment
        {
            string Name { get; }
            void ShowDepartmentInfo();
        }

        public interface IPayroll
        {
            void ProcessSalary(IEmployee employee);
        }

        public interface INotification
        {
            void Notify(IEmployee employee, string message);
        }

        public interface IReport
        {
            void GenerateReport(List<IEmployee> employees);
        }

        // ---------------- Departments ----------------
        public class CSDepartment : IDepartment
        {
            private string _name;

            public CSDepartment()
            {
                _name = "Computer Science";
            }

            public string Name
            {
                get { return _name; }
            }

            public void ShowDepartmentInfo()
            {
                Console.WriteLine("Department: " + _name + " - Offers BSc & MSc courses.");
            }
        }

        public class MathDepartment : IDepartment
        {
            private string _name;

            public MathDepartment()
            {
                _name = "Mathematics";
            }

            public string Name
            {
                get { return _name; }
            }

            public void ShowDepartmentInfo()
            {
                Console.WriteLine("Department: " + _name + " - Offers BSc & MSc courses.");
            }
        }

        // ---------------- Employees ----------------
        public class Professor : IEmployee
        {
            private string _fullName;

            public Professor(string name)
            {
                _fullName = name;
            }

            public string FullName
            {
                get { return _fullName; }
            }

            public void PerformDuty()
            {
                Console.WriteLine(_fullName + " is teaching classes.");
            }
        }

        public class LabAssistant : IEmployee
        {
            private string _fullName;

            public LabAssistant(string name)
            {
                _fullName = name;
            }

            public string FullName
            {
                get { return _fullName; }
            }

            public void PerformDuty()
            {
                Console.WriteLine(_fullName + " is managing lab equipment.");
            }
        }

        public class Administrator : IEmployee
        {
            private string _fullName;

            public Administrator(string name)
            {
                _fullName = name;
            }

            public string FullName
            {
                get { return _fullName; }
            }

            public void PerformDuty()
            {
                Console.WriteLine(_fullName + " is handling administrative work.");
            }
        }

        // ---------------- Payroll ----------------
        public class MonthlyPayroll : IPayroll
        {
            public void ProcessSalary(IEmployee employee)
            {
                Console.WriteLine("Monthly salary processed for " + employee.FullName);
            }
        }

        public class HourlyPayroll : IPayroll
        {
            public void ProcessSalary(IEmployee employee)
            {
                Console.WriteLine("Hourly payment processed for " + employee.FullName);
            }
        }

        // ---------------- Notifications ----------------
        public class EmailNotification : INotification
        {
            void INotification.Notify(IEmployee employee, string message)
            {
                Console.WriteLine("Email to " + employee.FullName + ": " + message);
            }
        }

        public class SMSNotification : INotification
        {
            void INotification.Notify(IEmployee employee, string message)
            {
                Console.WriteLine("SMS to " + employee.FullName + ": " + message);
            }
        }

        // ---------------- Reports ----------------
        public class SalaryReport : IReport
        {
            public void GenerateReport(List<IEmployee> employees)
            {
                Console.WriteLine("\n--- Salary Report ---");
                foreach (IEmployee emp in employees)
                {
                    Console.WriteLine(emp.FullName + " salary processed.");
                }
            }
        }

        public class AttendanceReport : IReport
        {
            public void GenerateReport(List<IEmployee> employees)
            {
                Console.WriteLine("\n--- Attendance Report ---");
                foreach (IEmployee emp in employees)
                {
                    Console.WriteLine(emp.FullName + " attended all assigned duties.");
                }
            }
        }

        // ---------------- Main Program ----------------
        class Employee_Payroll
        {
            static void Main1(string[] args)
            {
                // Departments
                List<IDepartment> departments = new List<IDepartment>()
            {
                new CSDepartment(),
                new MathDepartment()
            };

                Console.WriteLine("--- Departments Info ---");
                foreach (IDepartment dept in departments)
                {
                    dept.ShowDepartmentInfo();
                }

                // Employees
                List<IEmployee> staff = new List<IEmployee>()
            {
                new Professor("Dr. Smith"),
                new LabAssistant("Alice"),
                new Administrator("John")
            };

                Console.WriteLine("\n--- Staff Duties ---");
                foreach (IEmployee emp in staff)
                {
                    emp.PerformDuty();
                }

                // Payroll
                IPayroll payroll = new MonthlyPayroll();
                Console.WriteLine("\n--- Payroll Processing ---");
                foreach (IEmployee emp in staff)
                {
                    payroll.ProcessSalary(emp);
                }

                // Notifications (Explicit interface example)
                INotification email = new EmailNotification();
                INotification sms = new SMSNotification();

                Console.WriteLine("\n--- Notifications ---");
                email.Notify(staff[0], "Salary credited!");
                sms.Notify(staff[1], "Lab duties scheduled!");

                // Reports
                IReport salaryReport = new SalaryReport();
                IReport attendanceReport = new AttendanceReport();

                salaryReport.GenerateReport(staff);
                attendanceReport.GenerateReport(staff);
            }
        }
    }

}
