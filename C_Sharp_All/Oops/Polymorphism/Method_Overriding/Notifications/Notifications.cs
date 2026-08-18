using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_All.Oops.Polymorphism.Method_Overriding.Notifications
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }

    class Program
    {
        static void Main1()
        {
            INotification notification;

            notification = new EmailNotification();
            notification.Send("Your order has been shipped!");

            notification = new SMSNotification();
            notification.Send("Your OTP is 9876");

            notification = new PushNotification();
            notification.Send("New offer on electronics!");
        }
    }

}
