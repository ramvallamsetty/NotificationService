using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class UserService
    {
        private User User { get; set; }

        public bool CreateRegistration(string name, string emailAddress, string phoneNumber, DateTime? registeredDate, bool optForSMS)
        {
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(emailAddress) && !String.IsNullOrEmpty(phoneNumber) && registeredDate != null)
            {
                this.User = new User(name, emailAddress, phoneNumber, registeredDate, optForSMS);      
                return true;
            }
            return false;
        }

        public User GetUser()
        {
            return this.User;
        }
    }
}
