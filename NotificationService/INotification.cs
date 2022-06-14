using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public interface INotification
    {
        bool Notify(string subject, string message);
    }
}
