using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DustyCover
{
    internal class User
    {
        public string Email;
        public string Password;
        public string DisplayName;

        public User(string email, string password, string displayName)
        {
            Email = email;
            Password = password;
            DisplayName = displayName;
        }

    }
}
