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

            // Demo check - no real database yet, just a hardcoded test case
            if (email == "test@dustycover.com")
            {
                lblError.Text = "An account with this email already exists";
                lblError.Visible = true;
                return;
            }

            // If we get here, signup "succeeded" for demo purposes
            lblError.Visible = false;
            MessageBox.Show("Account created for " + fullName + "! (Demo only - not saved anywhere yet)");
        }
    }
}
