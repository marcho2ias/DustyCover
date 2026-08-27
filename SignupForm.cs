using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DustyCover
{
    public partial class SignupForm : Form
    {

        public SignupForm()
        {
            InitializeComponent();

            lblError.Visible = false;

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCA_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string fullName = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtCP.Text;

            string filePath = "D:\\Studio-2\\users.csv";

            if (fullName == "" || email == "" || password == "" || confirmPassword == "")
            {
                lblError.Text = "Please fill in all fields";
                lblError.Visible = true;
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Passwords do not match !!";
                lblError.Visible = true;
                return;
            }

            // Create the file with a header row if it doesn't exist yet
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.WriteAllText(filePath, "Name,Email,Password" + Environment.NewLine);
            }

            // Read all existing lines so we can check if the email is already registered
            string[] existingLines = System.IO.File.ReadAllLines(filePath);

            for (int i = 1; i < existingLines.Length; i++)   // start at 1 to skip the header row
            {
                string[] fields = existingLines[i].Split(',');
                if (fields.Length >= 2 && fields[1] == email)
                {
                    lblError.Text = "An account with this email already exists !!";
                    lblError.Visible = true;
                    return;
                }
            }

            // Build the new row and add it to the file
            string newLine = fullName + "," + email + "," + password;
            System.IO.File.AppendAllText(filePath, newLine + Environment.NewLine);

            MessageBox.Show("Account created successfully!");

            // Go back to the login form
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
            this.Hide();
        }
    }
}