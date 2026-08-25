using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Form1 : Form
    {
        private string loggedInUsername;
        private string csvFile;

        public Form1(string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            loggedInUsername = username;

            csvFile = Path.Combine(Application.StartupPath, "users.csv");

            LoadUserData();
            LoadBorrowedBooks();
        }
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
                    string password = data[2].Trim();

                    // Display user information
                    userNameLabel.Text =
                        "@" + username;

                    welcomeLabel.Text =
                        "Welcome," + username +
                        " to your user account page!";

                    emailTextBox.Text = email;

                    psswdTextBox.Text = password;

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

        private void LoadBorrowedBooks()
        {
            booksGrid.Rows.Clear();

            booksGrid.Rows.Add(
                "Fantacy",
                "25 Aug 2026"
            );

            booksGrid.Rows.Add(
                "Anime",
                "28 Aug 2026"
            );

            booksGrid.Rows.Add(
                "Mathematics",
                "02 Sep 2026"
            );

            booksGrid.Rows.Add(
                "Dictionary",
                "05 Sep 2026"
            );

        }

        private void editButton_Click(
            object sender,
            EventArgs e)
        {
            Form2 editForm =
                new Form2(loggedInUsername);

            editForm.ShowDialog();

            LoadUserData();
        }

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
        private void borrowingValue_Click(object sender, EventArgs e){}
        private void booksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}