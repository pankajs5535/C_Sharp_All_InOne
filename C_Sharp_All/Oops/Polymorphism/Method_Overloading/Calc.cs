using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Polymorphism.Method_Overloading
{
    using System;

    public class Calc
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add two double-precision floating-point numbers
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to subtract two integers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to multiply two integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to divide two integers
        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b;
        }

        // Method to calculate the area of a rectangle
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a circle
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Main method to demonstrate the overloaded methods
        public static void Main1(string[] args)
        {
            Calc calculator = new Calc();

            // Demonstrate addition
            Console.WriteLine("Addition (int + int): " + calculator.Add(10, 20));
            Console.WriteLine("Addition (double + double): " + calculator.Add(10.5, 20.5));

            // Demonstrate subtraction
            Console.WriteLine("Subtraction (10 - 5): " + calculator.Subtract(10, 5));

            // Demonstrate multiplication
            Console.WriteLine("Multiplication (10 * 5): " + calculator.Multiply(10, 5));

            // Demonstrate division
            try
            {
                Console.WriteLine("Division (10 / 2): " + calculator.Divide(10, 2));
                Console.WriteLine("Division (10 / 0): " + calculator.Divide(10, 0)); // This will throw an exception
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Demonstrate area calculation
            Console.WriteLine("Area of Rectangle (5 x 10): " + calculator.CalculateArea(5, 10));
            Console.WriteLine("Area of Circle (radius 7): " + calculator.CalculateArea(7));
        }
    }

     
}
