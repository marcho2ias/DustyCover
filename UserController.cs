using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DustyCover
{
    internal class UserController
    {
        private List<User> users;

        public UserController()
        {
            users = new List<User>();
            LoadHardcodedUsers();
        }

        // Sample accounts - swap for real registration/CSV loading later
        private void LoadHardcodedUsers()
        {
            users.Add(new User("dhruv@email.com", "password123", "Dhruv"));
            users.Add(new User("jeet@email.com", "password123", "Jeet"));               // example data
            users.Add(new User("krupa@email.com", "password123", "Krupa"));
            users.Add(new User("kit@email.com", "password123", "Kit"));
        }

        // Checks the email/password against every stored account.
        // Returns the matching User if found, or null if the login is wrong.
        public User ValidateLogin(string email, string password)
        {
            foreach (User user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
