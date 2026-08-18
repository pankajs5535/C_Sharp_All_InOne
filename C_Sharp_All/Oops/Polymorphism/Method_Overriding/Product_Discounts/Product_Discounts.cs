using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Polymorphism.Method_Overriding.Product_Discounts
{
    public abstract class Product
    {
        public double Price { get; set; }
        public abstract double CalculateDiscount();
    }

    public class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.10; // 10% discount
        }
    }

    public class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.20; // 20% discount
        }
    }

    public class Book : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5% discount
        }
    }

    class Program2
    {
        static void Main1()
        {
            Product product = new Electronics { Price = 10000 };
            Console.WriteLine($"Electronics Discount: {product.CalculateDiscount()}");

            product = new Clothing { Price = 2000 };
            Console.WriteLine($"Clothing Discount: {product.CalculateDiscount()}");

            product = new Book { Price = 500 };
            Console.WriteLine($"Book Discount: {product.CalculateDiscount()}");
        }
    }
}

