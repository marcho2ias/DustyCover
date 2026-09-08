using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DustyCover
{
    public partial class UserAccount : Form
    {
        private string loggedInEmail;
        private string csvFile;

        public UserAccount(string email)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            loggedInEmail = email;

            csvFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.csv");

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

                if (data.Length < 3)
                    continue;

                string name = data[0].Trim();
                string email = data[1].Trim();
                string password = data[2].Trim();

                if (email.Equals(loggedInEmail?.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    
                    userNameLabel.Text = name;

                    welcomeLabel.Text =
                        "Welcome, " + name +
                        " to your user account page!";

                    emailtextBox1.Text = email;
                    passwdBox1.Text = password;

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
                "Fantasy",
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
            Edit editForm = new Edit(loggedInEmail);
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
                "• Fantasy - Due 25 Aug 2026\n" +
                "• Anime - Due 28 Aug 2026\n" +
                "• Mathematics - Due 02 Sep 2026\n" +
                "• Dictionary - Due 05 Sep 2026\n\n" +
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
            this.Hide();
            Dashboardv2 dashboardv2 = new Dashboardv2();
            dashboardv2.Show();
        }

        private void borrowingValue_Click(object sender, EventArgs e) 
        {

        }
        private void booksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }
        private void rightPanel_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void emaitextBox1_TextChanged(object sender, EventArgs e) 
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {

        }
        private void emailLabel_Click(object sender, EventArgs e) 
        {

        }
        private void iconButton2_Click(object sender, EventArgs e) 
        {

        }
        private void UserAccount_Load(object sender, EventArgs e) 
        {

        }
    }
}