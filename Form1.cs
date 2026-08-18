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
        // Tracks whether the contact fields are currently editable
        private bool isEditingContactInfo = false;

        // Remembers the values before an edit, so we can restore them if needed
        private string savedEmail = string.Empty;
        private string savedPhone = string.Empty;

        public Form1()
        {
            InitializeComponent();

            // Wire up the button clicks here in case they aren't
            // already hooked up in Form1.Designer.cs.
            // (If double-clicking the buttons in the designer already
            // created handlers with different names, delete these three
            // lines and just rename the methods below to match.)
            this.button1.Click += new EventHandler(this.button1_Click);   // Edit
            this.button2.Click += new EventHandler(this.button2_Click);   // Borrowing/History
            this.button3.Click += new EventHandler(this.button3_Click);   // Log Out
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start with contact fields locked (view-only) until Edit is pressed
            SetContactFieldsEditable(false);

            // TODO: replace with real data loaded from your user/account source
            // textBox1.Text = currentUser.Email;
            // textBox2.Text = currentUser.Phone;
            // textBox3.Text = currentUser.BorrowedCount.ToString();
            // textBox4.Text = currentUser.TotalReads.ToString();
            // textBox5.Text = currentUser.FinesDue.ToString("C");
        }

        // ---------- EDIT BUTTON ----------
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isEditingContactInfo)
            {
                // Entering edit mode: remember current values, unlock the boxes
                savedEmail = textBox1.Text;
                savedPhone = textBox2.Text;

                SetContactFieldsEditable(true);
                button1.Text = "Save";
                isEditingContactInfo = true;
            }
            else
            {
                // Leaving edit mode: validate, then save
                if (!IsValidEmail(textBox1.Text))
                {
                    MessageBox.Show("Please enter a valid e-mail address.", "Invalid Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                if (!IsValidPhone(textBox2.Text))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Invalid Phone",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }

                // TODO: persist textBox1.Text / textBox2.Text to your database or user object
                // Example:
                // currentUser.Email = textBox1.Text;
                // currentUser.Phone = textBox2.Text;
                // userRepository.Save(currentUser);

                SetContactFieldsEditable(false);
                button1.Text = "Edit";
                isEditingContactInfo = false;

                MessageBox.Show("Account details updated.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ---------- BORROWING / HISTORY BUTTON ----------
        private void button2_Click(object sender, EventArgs e)
        {
            // Opens the Borrowing/History form.
            // Replace "BorrowingHistoryForm" with the actual name of that form in your project.
            try
            {
                using (var historyForm = new Form3())
                {
                    historyForm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Borrowing/History: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- LOG OUT BUTTON ----------
        private void button3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Replace "LoginForm" with the actual name of your login/start-up form
                var login = new Form();
                login.Show();
                this.Hide();     // hide instead of Close() so the app doesn't shut down entirely

                // If Form1 should be fully disposed on logout instead, use:
                // this.Close();
            }
        }

        // ---------- HELPERS ----------
        private void SetContactFieldsEditable(bool editable)
        {
            textBox1.ReadOnly = !editable; // e-mail
            textBox2.ReadOnly = !editable; // phone

            textBox1.BackColor = editable ? SystemColors.Window : SystemColors.Control;
            textBox2.BackColor = editable ? SystemColors.Window : SystemColors.Control;
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
            // Allows digits, spaces, +, -, ( ) — adjust to your needs
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9+\-\s()]{7,15}$");
        }

        // ---------- EXISTING STUBS (kept as-is / left empty) ----------
        private void panel1_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void label1_Click(object sender, EventArgs e) 
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void label4_Click_2(object sender, EventArgs e) 
        {

        }
        private void emaillogo_Click(object sender, EventArgs e) 
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void panel7_Paint(object sender, PaintEventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}