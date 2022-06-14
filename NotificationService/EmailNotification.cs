using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class EmailNotification : INotification
    {
        readonly string EmailAddress;
        readonly IEmailProvider Provider;
        readonly User User;

        public EmailNotification(string emailAddress, IEmailProvider provider)
        {
            EmailAddress = emailAddress;
            Provider = provider;
        }
        public EmailNotification(User user, IEmailProvider provider)
        {
            this.User = user;
            Provider = provider;
        }
        public bool Notify(string subject, string message)
        {
            if(User != null)
            Console.WriteLine($"Email is queued for the user {User.GetName()} at his email {User.GetEmailAddress()} with the subject {subject} using the provider  to {Provider.Provider}");
            else
            Console.WriteLine($"Email is queued for the user at his email {EmailAddress} with the subject {subject}  using the provider {Provider.Provider}");
            //throw new ApplicationException("Test Exception tests");

            return true;
        }
    }
}
