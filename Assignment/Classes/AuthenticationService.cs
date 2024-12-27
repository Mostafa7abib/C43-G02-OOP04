using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    internal class AuthenticationService : IAuthenticationService

    {
        string? StoredUserName = "user";
        string? StoredPassword = "passowrd";
        string? StoredRole = "admin";
        public bool AuthenticateUser(string UserName, string Password)
        {
            return UserName == StoredUserName && Password == StoredPassword;

        }

        public bool AuthorizeUser(string UserName, string Role)
        {
            return UserName == StoredUserName && Role == StoredRole;
        }

    }
}
