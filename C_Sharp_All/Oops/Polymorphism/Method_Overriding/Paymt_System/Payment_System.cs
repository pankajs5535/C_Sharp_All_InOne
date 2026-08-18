using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Polymorphism.Method_Overriding.Paymt_System
{
    public abstract class Payment
    {
        public abstract void MakePayment(double amount);
    }

    public class CreditCardPayment : Payment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    public class UPIPayment : Payment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine($"Paid {amount} using UPI.");
        }
    }

    public class PayPalPayment : Payment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }

    class Program
    {
        static void Main1()
        {
            Payment payment;

            payment = new CreditCardPayment();
            payment.MakePayment(5000);

            payment = new UPIPayment();
            payment.MakePayment(2500);

            payment = new PayPalPayment();
            payment.MakePayment(1000);
        }
    }

}

/*
 
 🛒 Example: In an E-commerce Website (like Amazon)

Let’s imagine you’re developing features for Amazon’s checkout system or shopping cart.

🧠 Scenario 1: Different Payment Methods

You have multiple ways to pay:

Credit Card

Debit Card

Net Banking

UPI

PayPal

All payment methods must have a common action — say, MakePayment() — but the implementation differs.

So you can have:

A base class/interface → Payment

And derived classes → CreditCardPayment, UPIPayment, PayPalPayment, etc.

Each derived class implements its own version of MakePayment() — this is runtime polymorphism.
When the user chooses UPI or PayPal, the correct method runs at runtime automatically.

👉 Benefit: You can easily add a new payment type (e.g., “Amazon Pay”) without changing the existing code. You just create a new class that inherits from Payment.
 
 
 
 */