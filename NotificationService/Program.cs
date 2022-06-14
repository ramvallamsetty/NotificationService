using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.CreateRegistration("John", "john@abc.com", "17032589635", DateTime.Now, true);

            IList<INotification> notifications = new List<INotification>();

            notifications.Add(new EmailNotification(userService.GetUser(), new IEmailProvider("SendGrid")));
            if(userService.GetUser().OptForSMS == true)
            {
                //INotification notification = new SMSNotification("125522254789", new ISMSSender("Twilio"));
                notifications.Add(new SMSNotification(userService.GetUser(), new ISMSSender("Twilio")));
            }
            foreach (var notification in notifications)
            {
                notification.Notify("Order Confirmation", "Hello, your order has been submitted");
            }
            
            Console.ReadLine();
        }
    }
}
