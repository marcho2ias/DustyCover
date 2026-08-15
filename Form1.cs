using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Form1 : Form
    {

        private UserController userController;

        public Form1()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User matchedUser = userController.ValidateLogin(email, password);

            if (matchedUser != null)
            {
                // Save the logged-in user so every other form can read it
                CurrentUser.LoggedInUser = matchedUser;

                lblError.Visible = false;

                // Open the borrowing history page (Form2) and close the login window
                Form2 borrowingForm = new Form2();
                borrowingForm.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Incorrect email or password";
                lblError.Visible = true;
            }
        }
    }
}
