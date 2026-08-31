using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DustyCover
{
    public partial class LoginForm : Form
    {
        private UserController userController;

        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();

            // Set up placeholder text for email and password
            txtEmail.Text = "example123@gmail.com";
            txtEmail.ForeColor = Color.Gray;
            txtEmail.SelectionStart = 0; // move cursor to the start so the beginning of the text is visible

            txtPassword.Text = ".........";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '\0'; // show as plain text while it's just the placeholder
            txtPassword.SelectionStart = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Prevent any control from automatically having focus when the form opens,
            // so the placeholder text doesn't show a blinking cursor before the user clicks in
            this.ActiveControl = null;

            // Rounds the corners of lblBadge into a pill shape
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 10;
            Rectangle rect = lblBadge.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            lblBadge.Region = new Region(path);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "example123@gmail.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "example123@gmail.com";
                txtEmail.ForeColor = Color.Gray;
                txtEmail.SelectionStart = 0;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == ".........")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '*'; // start masking real typed input
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = ".........";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0'; // unmask so the placeholder shows as plain dots text
                txtPassword.SelectionStart = 0;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Don't try to log in with the placeholder text itself
            if (email == "example123@gmail.com" || password == ".........")
            {
                lblError.Text = "Please enter your email and password";
                lblError.Visible = true;
                return;
            }

            User matchedUser = userController.ValidateLogin(email, password);

            if (matchedUser != null)
            {
                // Save the logged-in user so every other form can read it
                CurrentUser.LoggedInUser = matchedUser;

                lblError.Visible = false;

                // TODO: open the borrowing history page once it's rebuilt.
                // For now, just confirm login worked.
                MessageBox.Show("Login successful! Welcome, " + matchedUser.DisplayName);
            }
            else
            {
                lblError.Text = "Incorrect email or password";
                lblError.Visible = true;
            }

            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();

        }

        
    }
}
