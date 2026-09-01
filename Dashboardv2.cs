using System;
using System.Drawing;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Dashboardv2 : Form
    {
        public Dashboardv2()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
         
            try
            {
                this.BackgroundImage = Image.FromFile(@"C:\path\to\your\image.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
              
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
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }
    }
}