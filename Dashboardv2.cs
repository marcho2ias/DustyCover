using System;
using System.Drawing;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Dashboardv2 : Form
    {
        public string LoggedInUsername;

        public Dashboardv2(string username)
        {
            InitializeComponent();
            LoggedInUsername = username;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage =
                    Image.FromFile(@"C:\path\to\your\image.jpg");

                this.BackgroundImageLayout =
                    ImageLayout.Stretch;
            }
            catch
            {
                this.BackColor =
                    Color.FromArgb(247, 238, 226);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            // Pass the active logged-in user's email or display name instead of hardcoding "TestUser"
            if (CurrentUser.LoggedInUser != null)
            {
                UserAccount userAcc = new UserAccount(CurrentUser.LoggedInUser.Email);
                userAcc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No user is currently logged in.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnBookGenre_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentUser.LoggedInUser = null; 
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }
    }
}