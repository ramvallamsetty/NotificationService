using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class SMSNotification : INotification
    {
        readonly string Receiver;
        readonly ISMSSender Sender;

        public SMSNotification(string receiver, ISMSSender smsSender)
        {
            Receiver = receiver;    
            Sender = smsSender; 
        }
        public SMSNotification(User user, ISMSSender smsSender)
        {
            Receiver = user.GetPhoneNumber(); ;
            Sender = smsSender;
        }
        public bool Notify(string subject, string message)
        {
            Console.WriteLine($"SMS is handed over to {Sender.Provider} for this {Receiver} with the subject {subject}");
            return true;
        }
    }
}
