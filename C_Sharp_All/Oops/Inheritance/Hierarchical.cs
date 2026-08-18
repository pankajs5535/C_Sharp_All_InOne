using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Inheritance
{
    public class NotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Notification: {message}");
        }
    }

    public class EmailNotification : NotificationService
    {
        public void SendEmail(string email, string message)
        {
            SendNotification(message);
            Console.WriteLine($"Email sent to: {email}");
        }
    }

    public class SmsNotification : NotificationService
    {
        public void SendSms(string phoneNumber, string message)
        {
            SendNotification(message);
            Console.WriteLine($"SMS sent to: {phoneNumber}");
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            EmailNotification emailNotification = new EmailNotification();
            emailNotification.SendEmail("user@example.com", "Welcome!");

            SmsNotification smsNotification = new SmsNotification();
            smsNotification.SendSms("123-456-7890", "Your OTP is 1234.");
        }
    }

}
