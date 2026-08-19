using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Form1 : Form
    {
        // Username of the currently logged-in user
        private string loggedInUsername;

        // CSV file location
        private string csvFile;

        public Form1(string username)
        {
            InitializeComponent();

            loggedInUsername = username;

            csvFile = Path.Combine(
                Application.StartupPath,
                "users.csv"
            );

            LoadUserData();
            LoadBorrowedBooks();
        }


        // =========================================================
        // LOAD USER DATA FROM CSV
        // =========================================================

        private void LoadUserData()
        {
            if (!File.Exists(csvFile))
            {
                MessageBox.Show(
                    "users.csv could not be found.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            string[] lines = File.ReadAllLines(csvFile);

            if (lines.Length <= 1)
            {
                MessageBox.Show(
                    "There are no users in the CSV file.",
                    "CSV Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',');

                if (data.Length < 4)
                    continue;

                string username = data[0].Trim();

                if (username.Equals(
                    loggedInUsername,
                    StringComparison.OrdinalIgnoreCase))
                {
                    string email = data[1].Trim();
                    string phone = data[2].Trim();

                    // Display user information
                    userNameLabel.Text =
                        "@" + username;

                    welcomeLabel.Text =
                        "Welcome, @" + username +
                        " to your user account page!";

                    emailTextBox.Text = email;

                    phoneTextBox.Text = phone;

                    return;
                }
            }

            MessageBox.Show(
                "The logged-in user could not be found.",
                "User Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }


        // =========================================================
        // BORROWED BOOKS
        // =========================================================

        private void LoadBorrowedBooks()
        {
            booksGrid.Rows.Clear();

            booksGrid.Rows.Add(
                "The Alchemist",
                "25 Aug 2026"
            );

            booksGrid.Rows.Add(
                "Atomic Habits",
                "28 Aug 2026"
            );

            booksGrid.Rows.Add(
                "The 5 AM Club",
                "02 Sep 2026"
            );

            booksGrid.Rows.Add(
                "Rich Dad Poor Dad",
                "05 Sep 2026"
            );

            booksGrid.Rows.Add(
                "Think and Grow Rich",
                "08 Sep 2026"
            );
        }


        // =========================================================
        // EDIT BUTTON
        // =========================================================

        private void editButton_Click(
            object sender,
            EventArgs e)
        {
            Form2 editForm =
                new Form2(loggedInUsername);

            // Show Form2
            editForm.ShowDialog();

            // Reload information after Form2 closes
            LoadUserData();
        }


        // =========================================================
        // BORROWING / HISTORY BUTTON
        // =========================================================

        private void historyButton_Click(
            object sender,
            EventArgs e)
        {
            string history =
                "BORROWING HISTORY\n\n" +

                "Currently Borrowed:\n\n" +

                "• The Alchemist - Due 25 Aug 2026\n" +
                "• Atomic Habits - Due 28 Aug 2026\n" +
                "• The 5 AM Club - Due 02 Sep 2026\n" +
                "• Rich Dad Poor Dad - Due 05 Sep 2026\n" +
                "• Think and Grow Rich - Due 08 Sep 2026\n\n" +

                "Total Borrowed: 07\n" +
                "Total Reads: 24";

            MessageBox.Show(
                history,
                "Borrowing / History",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // LOGOUT
        // =========================================================

        private void logoutButton_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Log Out",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void emailIcon_Click(object sender, EventArgs e)
        {

        }

        private void borrowingValue_Click(object sender, EventArgs e)
        {

        }
    }
}