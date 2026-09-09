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

            string[] lines = File.ReadAllLines(csvFile);

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',');

                if (data.Length < 3)
                    continue;

                if (data[0].Trim().Equals(
                    loggedInUsername,
                    StringComparison.OrdinalIgnoreCase))
                {
                    emailTextBox.Text = data[1].Trim();
                    PasswordTextBox.Text = data[2].Trim();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newEmail = emailTextBox.Text.Trim();
            string newPassword = PasswordTextBox.Text.Trim();

            // Email validation
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

            if (!newEmail.Contains("@") || !newEmail.Contains("."))
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

            // Password validation
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                PasswordTextBox.Focus();
                return;
            }

            try
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
                bool userFound = false;

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]))
                        continue;

                    string[] data = lines[i].Split(',');

                    if (data.Length < 3)
                        continue;

                    if (data[0].Trim().Equals(
                        loggedInUsername,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        string username = data[0].Trim();

                        lines[i] = username + "," + newEmail + "," + newPassword;

                        userFound = true;
                        break;
                    }
                }

                if (!userFound)
                {
                    MessageBox.Show(
                        "User could not be found in users.csv.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                File.WriteAllLines(csvFile, lines);

                MessageBox.Show(
                    "Your information has been updated successfully!",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Dashboardv2 dashboard = new Dashboardv2(loggedInUsername);
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while updating your information:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e) 
        {

        }

        private void passwdLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}