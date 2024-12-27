using Assignment.Classes;
using Assignment.Interfaces;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Q1 
            //IAuthenticationService service = new AuthenticationService();
            //IAuthenticationService Authorize = new AuthenticationService();
            //bool Authenticated = service.AuthenticateUser("user", "passowrd");
            //if (Authenticated)
            //    Console.WriteLine($"Authenticated: {Authenticated}");
            //else Console.WriteLine("UnAthenticated!");
            //bool Authorized = Authorize.AuthorizeUser("user2", "admin");
            //if (Authorized)
            //    Console.WriteLine($"Authorized: {Authorized}");
            //else Console.WriteLine("UnAuthorized!");

            #endregion

            #region Part1 Q2
            INotificationService Email_notification = new EmailNotificationService();
            INotificationService Sms_notification = new SmsNotificationService();
            INotificationService Push_notification = new PushNotificationService();
            Email_notification.SendNotification("mostafamohabib1234@gmail.com", "This Message Via An Email!");
            Sms_notification.SendNotification("Et Cash", "This Message Via An Sms!");
            Push_notification.SendNotification("sasa", "This Message Via An Push Noification!");
            #endregion
        }
    }
}
