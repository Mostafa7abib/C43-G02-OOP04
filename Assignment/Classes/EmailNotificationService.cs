using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recpint, string message)
        {
            Console.WriteLine($"Email_Notification_Service sent to {recpint} with Message: {message}");

        }
    }
}