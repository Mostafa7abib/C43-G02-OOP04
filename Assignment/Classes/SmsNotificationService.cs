using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    internal class SmsNotificationService : INotificationService

    {
        public void SendNotification(string recpint, string message)
        {
            Console.WriteLine($"Sms_Notification_Service sent to {recpint} with Message: {message}");

        }
    }
}
