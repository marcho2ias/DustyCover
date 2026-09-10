using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreProj
{
    public partial class payment : Form
    {
        private string order;
        private double total;
        private int orderNumber;

        public payment(string order, double total)
        {
            InitializeComponent();
            this.total = total;
            this.order = order;

            // Generate order number automatically
            orderNumber = GenerateOrderNumber();

            // Display order details
            
        }

        private int GenerateOrderNumber()
        {
            try
            {
                // Get the correct path to Resources folder in the project
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                // Go up to the project folder (if running from bin\Debug)
                string projectPath = Path.GetFullPath(Path.Combine(projectDirectory, @"..\..\"));
                string filePath = Path.Combine(projectPath, "Resources", "Orders.csv");

                // Check if file exists
                if (!File.Exists(filePath))
                {
                    return 1000; // Start from 1000 if file doesn't exist
                }

                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // If file only has header or is empty, start from 1000
                if (lines.Length <= 1)
                {
                    return 1000;
                }

                // Get the last order number
                string lastLine = lines[lines.Length - 1];
                string[] data = lastLine.Split(',');

                if (data.Length >= 1 && int.TryParse(data[0], out int lastOrderNumber))
                {
                    return lastOrderNumber + 1;
                }

                return 1000;
            }
            catch
            {
                return 1000;
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool status = false;

            string Fullname = txt_payment_fullName.Text;
            string CardNumber = txt_Payment_CardNumber.Text;
            string ExpMonth = txt_Payment_CardNumber.Text;
            string ExpYear = txt_expYear.Text;
            string CVV = txt_Cvv.Text;

            status = true;

            if ( Fullname == "" || CardNumber == "" || ExpMonth == "" || ExpYear == "" || CVV == "")
            {
                MessageBox.Show("Please input all the necessary Information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                status = false; 
            }

           else 




            {


                try
                {
                    // Get the correct path to Resources folder
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    // Go up to the project folder (if running from bin\Debug)
                    string projectPath = Path.GetFullPath(Path.Combine(projectDirectory, @"..\..\"));
                    string folderPath = Path.Combine(projectPath, "Resources");
                    string filePath = Path.Combine(folderPath, "Orders.csv");

                    // Create Resources folder if it doesn't exist
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    bool fileExists = File.Exists(filePath);

                    using (StreamWriter writer = new StreamWriter(filePath, append: true))
                    {
                        // Write header if file doesn't exist
                        if (!fileExists)
                        {
                            writer.WriteLine("OrderNumber,Date,Order,Total");
                        }

                        // Write order data
                        string safeOrder = "\"" + order.Replace("\"", "\"\"") + "\"";
                        writer.WriteLine($"{orderNumber},{DateTime.Now:yyyy-MM-dd HH:mm:ss},{safeOrder},{total:0.00}");
                    }



                    DialogResult result = MessageBox.Show("Order have sucessfully submiited order number: " + ($"Order #{orderNumber}",
                         "Success", MessageBoxButtons.OK, MessageBoxIcon.Information));

                    if (result == DialogResult.OK)

                    {
                        Genre genre = new Genre();

                        genre.Show();

                        this.Close();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save order: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void payment_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}