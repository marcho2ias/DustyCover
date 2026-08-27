using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string filePath = "D:\\Studio-2\\users.csv";

        public UserController()
        {
            users = new List<User>();
            LoadUsersFromCsv();
        }

        // Loads every signed-up account from users.csv into the users list
        private void LoadUsersFromCsv()
        {
            if (!System.IO.File.Exists(filePath))
            {
                return; // no one has signed up yet, so leave the list empty
            }

            string[] existingLines = System.IO.File.ReadAllLines(filePath);

            for (int i = 1; i < existingLines.Length; i++)   // start at 1 to skip the header row
            {
                string[] fields = existingLines[i].Split(',');

                if (fields.Length >= 3)
                {
                    string name = fields[0];
                    string email = fields[1];
                    string password = fields[2];

                    users.Add(new User(email, password, name));
                }
            }
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