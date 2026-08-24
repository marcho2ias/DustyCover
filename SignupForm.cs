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
        private UserController userController;

        public SignupForm()
        {
            InitializeComponent();
            userController = new UserController();
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
           
        }
    }
}
