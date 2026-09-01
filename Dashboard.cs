using System;
using System.Drawing;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Set Background Image programmatically
            try
            {
                this.BackgroundImage = Image.FromFile(@"C:\path\to\your\image.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                // Fallback color if image path is not found
                this.BackColor = Color.FromArgb(247, 238, 226);
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
            UserAccount userAcc = new UserAccount("TestUser");
            userAcc.Show();
            this.Hide();
        }

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            //for login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnBookGenre_Click(object sender, EventArgs e)
        {
            // BookGenrePage genrePage = new BookGenrePage();
            // genrePage.Show();
            // this.Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // CartPage cartPage = new CartPage();
            // cartPage.Show();
            // this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // SettingsPage settingsPage = new SettingsPage();
            // settingsPage.Show();
            // this.Hide();
        }
    }
}