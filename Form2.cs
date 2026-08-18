using System;
using System.Windows.Forms;

namespace DustyCover
{
    public partial class Form2 : Form
    {
        // Set after Save is clicked successfully; read these back
        // from Form1 after ShowDialog() returns DialogResult.OK.
        public string UpdatedEmail { get; private set; }
        public string UpdatedPhone { get; private set; }

        public Form2(string currentEmail, string currentPhone)
        {
            InitializeComponent();
            txtEmail.Text = currentEmail;
            txtPhone.Text = currentPhone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid e-mail address.", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Phone",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            UpdatedEmail = txtEmail.Text;
            UpdatedPhone = txtPhone.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9+\-\s()]{7,15}$");
        }
    }
}