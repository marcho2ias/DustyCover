using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Edit : Form
    {
        private string loggedInUsername;

        private string csvFile;

        public Edit(string username)
        {
            InitializeComponent();

            loggedInUsername = username;

            csvFile = Path.Combine(
                Application.StartupPath,
                "users.csv"
            );

            LoadUserData();
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

            string[] lines =
                File.ReadAllLines(csvFile);

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data =
                    line.Split(',');

                if (data.Length < 4)
                    continue;

                if (data[0].Trim().Equals(
                    loggedInUsername,
                    StringComparison.OrdinalIgnoreCase))
                {
                    usernameTextBox.Text =
                        data[0].Trim();

                    emailTextBox.Text =
                        data[1].Trim();

                    phoneTextBox.Text =
                        data[2].Trim();

                    usernameTextBox.ReadOnly = true;

                    return;
                }
            }
        }
        private void saveButton_Click(
            object sender,
            EventArgs e)
        {
            string newEmail =
                emailTextBox.Text.Trim();

            string newPhone =
                phoneTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show(
                    "Please enter your email.",
                    "Missing Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                emailTextBox.Focus();

                return;
            }


            if (!newEmail.Contains("@"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                emailTextBox.Focus();

                return;
            }


            if (string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show(
                    "Please enter your phone number.",
                    "Missing Phone",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                phoneTextBox.Focus();

                return;
            }

            string[] lines =
                File.ReadAllLines(csvFile);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                string[] data =
                    lines[i].Split(',');

                if (data.Length < 4)
                    continue;


                if (data[0].Trim().Equals(
                    loggedInUsername,
                    StringComparison.OrdinalIgnoreCase))
                {
                   
                    string username =
                        data[0].Trim();

                    string password =
                        data[3].Trim();

                    lines[i] =
                        username + "," +
                        newEmail + "," +
                        newPhone + "," +
                        password;

                    break;
                }
            }

            File.WriteAllLines(
                csvFile,
                lines
            );


            MessageBox.Show(
                "Your information has been updated successfully!",
                "Update Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
        private void cancelButton_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e){}
        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}