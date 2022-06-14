using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class User
    {
        private string Name { get; set; }
        private string EmailAddress { get; set; }
        private string PhoneNumber { get; set; }
        private DateTime? RegisteredDate{ get; set; }
        public bool OptForSMS { get; set; }

        public User(string name, string emailAddress, string phoneNumber, DateTime? registeredDate, bool optForSMS)
        {
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            RegisteredDate = registeredDate;
            OptForSMS = optForSMS;
        }
        public string GetEmailAddress()
        {
            return EmailAddress;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string GetName()
        {
            return Name;
        }

    }
}
