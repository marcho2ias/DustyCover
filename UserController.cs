using System;
using System.Collections.Generic;
using System.IO;

namespace DustyCover
{
    internal class UserController
    {
        private List<User> users;

        public string filePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "users.csv"
        );

        public UserController()
        {
            users = new List<User>();
            LoadUsersFromCsv();
        }

        // Loads every signed-up account from users.csv into the users list
        private void LoadUsersFromCsv()
        {
            users.Clear();

            if (!File.Exists(filePath))
            {
                return;
            }

            string[] existingLines = File.ReadAllLines(filePath);

            for (int i = 1; i < existingLines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(existingLines[i]))
                    continue;

                string[] fields = existingLines[i].Split(',');

                if (fields.Length >= 3)
                {
                    string name = fields[0].Trim();
                    string email = fields[1].Trim();
                    string password = fields[2].Trim();

                    users.Add(
                        new User(email, password, name)
                    );
                }
            }
        }

        // Checks email/password against stored accounts
        public User ValidateLogin(string email, string password)
        {
            // Reload so newly created accounts are included
            LoadUsersFromCsv();

            foreach (User user in users)
            {
                if (user.Email.Equals(
                        email.Trim(),
                        StringComparison.OrdinalIgnoreCase)
                    && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }
    }
}