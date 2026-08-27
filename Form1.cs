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

        private Point groupBox1OriginalLocation;
        private Point groupBox2OriginalLocation;
        private Point groupBox3OriginalLocation;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill in each book's title and status text.
            // pictureBox1/2/3 already have their cover images set in the Designer.
            label2.Text = "Atomic Habits";
            Status1.Text = "Due 12 Aug";

            label3.Text = "The Courage to Be Disliked";
            Status2.Text = "Overdue - was due 8 Aug";

            label4.Text = "The Art of Winning";
            Status3.Text = "Returned 2 Aug";

            groupBox1OriginalLocation = groupBox1.Location;
            groupBox2OriginalLocation = groupBox2.Location;
            groupBox3OriginalLocation = groupBox3.Location;

            // Start on "All" - everything visible
            ShowAll();
        }

        // Moves whichever GroupBoxes are currently visible up so they
        // stack from the top, instead of leaving gaps where hidden ones were
        private void ArrangeVisibleGroupBoxes()
        {
            int gap = 15; // space between boxes
            int currentY = groupBox1OriginalLocation.Y; // top starting position

            if (groupBox1.Visible)
            {
                groupBox1.Location = new Point(groupBox1OriginalLocation.X, currentY);
                currentY += groupBox1.Height + gap;
            }

            if (groupBox2.Visible)
            {
                groupBox2.Location = new Point(groupBox2OriginalLocation.X, currentY);
                currentY += groupBox2.Height + gap;
            }

            if (groupBox3.Visible)
            {
                groupBox3.Location = new Point(groupBox3OriginalLocation.X, currentY);
                currentY += groupBox3.Height + gap;
            }
        }
        private void ShowAll()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            ArrangeVisibleGroupBoxes();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Allbtn_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void Activebtn_Click(object sender, EventArgs e)
        {
            // Book 1 (Atomic Habits) is the only Active one
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            ArrangeVisibleGroupBoxes();
        }

        private void Duebtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            ArrangeVisibleGroupBoxes();
        }

        private void Returnedbtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            ArrangeVisibleGroupBoxes();
        }
    }
}
