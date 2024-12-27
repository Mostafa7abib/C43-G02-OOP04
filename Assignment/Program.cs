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
            //INotificationService Email_notification = new EmailNotificationService();
            //INotificationService Sms_notification = new SmsNotificationService();
            //INotificationService Push_notification = new PushNotificationService();
            //Email_notification.SendNotification("mostafamohabib1234@gmail.com", "This Message Via An Email!");
            //Sms_notification.SendNotification("Et Cash", "This Message Via An Sms!");
            //Push_notification.SendNotification("sasa", "This Message Via An Push Noification!");
            #endregion

            try
            {
                Console.WriteLine("Enter Cordinate for P1:");
                Point3D p1 = ReadPoint();
                Console.WriteLine("Enter Cordinate for P2:");
                Point3D p2 = ReadPoint();
                Console.WriteLine($"P1: {p1}");
                Console.WriteLine($"P2: {p2}");
                Console.WriteLine($"P1 == P2 ? {p1 == p2}!");
                Point3D[] points = new Point3D[]
                {
                    new Point3D(1,2,3),
                    new Point3D(4,5,6),
                    new Point3D(10,3,4),
                    new Point3D(7,8,9)
                };
                Array.Sort(points);
                foreach (var point in points)
                {
                    Console.WriteLine(point);
                }
                Point3D p3 = (Point3D)p1.Clone();
                Console.WriteLine($"P3: {p3}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Erorr! Try Again Later");
            }
        }
        private static Point3D ReadPoint()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                if (parts.Length == 3 &&
                    int.TryParse(parts[0], out int Num1) &&
                    int.TryParse(parts[1], out int Num2) &&
                    int.TryParse(parts[2], out int Num3))
                {
                    return new Point3D(Num1, Num2, Num3);
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

    }
}

