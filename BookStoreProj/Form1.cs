using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreProj
{
    public partial class Form1 : Form


    {
        Book book = new Book(15, 25, "The Little Mermaid", "Buy or Rent", "Faitytale");
        int price = 0;

        Book book1 = new Book(15, 25, "The Little Mermaid2", "Buy or Rent", "Faitytale");
       

        Order order = new Order();

        int cnt = 0;
        int total = 0;



        public Form1()
        {
            InitializeComponent();

            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = false;

            panel_cart1.Visible = false;


        }

        private void Panel_Genre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart1.Visible = false;




            label_fairyNameB1.Text = book.Name;
            label_descBookF.Text = "Rent $:" + book.Rentprice + "Buy:" + book.BuyPrice;

            label2_fairybook1.Text = book1.Name;
            






        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_buy1_Click(object sender, EventArgs e)


        {
            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
            panel_cart1.Visible = false;
            


            {
              

                // Add 1 book
                cnt++;

                // Display book name
                listBox_Cart.Items.Add((book.Name + "$".PadLeft(20) +book.BuyPrice.ToString()));

                // Display price of one book
                //listBox_Cart.Items.Add(book.BuyPrice.ToString().PadLeft(80));

                // Calculate total price
                 total = book.BuyPrice * cnt;

                // Display total
                label_Total.Text = "$" + total;

                label_cart.Text = cnt.ToString();


                

                
            }
        }






        private void label_cartPrice1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = false;
            Panel_Genre.Visible = true;
            panel_cart1.Visible = false;



        }

        private void button4_Click(object sender, EventArgs e)
        {

            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
            panel_cart1.Visible = false;

        }

        private void Panel_faitytale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
            panel_cart1.Visible = false;
         




            // Add 1 book
            cnt++;

            // Display book name
            listBox_Cart.Items.Add(book1.Name);

             total = book1.BuyPrice * cnt;

            // Display price of one book
            listBox_Cart.Items.Add(book1.BuyPrice.ToString().PadRight(25) + "$" + total);

            // Calculate total price
         

            // Display total
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

       
        private void button5_Click_1(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
            panel_cart1.Visible = true;
            panel_cart1.BringToFront();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox_Cart.Items.Clear();

            total = 0;
            cnt = 0;


            label_Total.Text = "$" + total;
            label_cart.Text = cnt.ToString();
            

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void panel_cart1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }


