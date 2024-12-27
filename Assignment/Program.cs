using Assignment.Classes;
using Assignment.Interfaces;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Q1 
            IAuthenticationService service = new AuthenticationService();
            IAuthenticationService Authorize = new AuthenticationService();
            bool Authenticated = service.AuthenticateUser("user", "passowrd");
            if (Authenticated)
                Console.WriteLine($"Authenticated: {Authenticated}");
            else Console.WriteLine("UnAthenticated!");
            bool Authorized = Authorize.AuthorizeUser("user2", "admin");
            if (Authorized)
                Console.WriteLine($"Authorized: {Authorized}");
            else Console.WriteLine("UnAuthorized!");

            #endregion
        }
    }
}
