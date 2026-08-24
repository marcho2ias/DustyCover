using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookStoreProj
{

    public partial class Form1 : Form


    {
        public string filePath = @"C:\Users\itsme\Documents\Studio2\Book.Txt";
        List<Book> books = new List<Book>();



        int cnt = 0;
        int total = 0;



        public Form1()
        {
            InitializeComponent();

            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = false;

           

           


        }

        private void Panel_Genre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;



            string filePath = @"C:\Users\itsme\Documents\Studio2\Book1.CSV";

            string[] lines = File.ReadAllLines(filePath);
            List<Book> books = new List<Book>();


            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                if (data.Length < 6)
                    continue; // skip malformed/incomplete lines

                Book book = new Book();
                book.BookID = data[0].Trim();
                book.Tittle = data[1].Trim();
                book.Description = data[2].Trim();
                book.BuyPrice = Convert.ToDouble(data[4].Trim());
                book.RentPrice = Convert.ToDouble(data[5].Trim());

                books.Add(book);
            }


            label1_Library.Text = books[0].Tittle;
            label2_Library.Text = books[1].Tittle;
            label3_Library.Text = books[2].Tittle;
            label4_Library.Text = books[3].Tittle;
            label5_Library.Text = books[4].Tittle;


            label1_price.Text ="Buy Price:" +  books[0].BuyPrice.ToString() +" Rent Price :" + books[0].RentPrice.ToString();









        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_buy1_Click(object sender, EventArgs e)


        {
            //Panel_faitytale.Visible = true;
            //Panel_Genre.Visible = true;




            {


                // Add 1 book
                cnt++;

                // Display book name
                //listBox_Cart.Items.Add((book.Name + "$".PadLeft(20) + book.BuyPrice.ToString()));

                // Display price of one book
                //listBox_Cart.Items.Add(book.BuyPrice.ToString().PadLeft(80));

                // Calculate total price
                //total = book.BuyPrice * cnt;

                //// Display total
                //label_Total.Text = "$" + total;

                //label_cart.Text = cnt.ToString();



                //if (cnt <= 1)
                //{
                //    Label_cart_notif.Text = "Cart Successfully Added";





                //}







            }
        }






        private void label_cartPrice1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = false;
            Panel_Genre.Visible = true;
            //panel_cart1.Visible = false;



        }

        private void button4_Click(object sender, EventArgs e)
        {

            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
            //panel_cart1.Visible = false;

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
            //panel_cart1.Visible = false;





            // Add 1 book
            cnt++;

            // Display book name
            //listBox_Cart.Items.Add(book1.Name);

            //total = book1.BuyPrice * cnt;

            // Display price of one book
            //listBox_Cart.Items.Add(book1.BuyPrice.ToString().PadRight(25) + "$" + total);

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
            //panel_cart1.Visible = true;
            //panel_cart1.BringToFront();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
          /*  listBox_Cart.Items.Clear();*/

            total = 0;
            cnt = 0;


            //label_Total.Text = "$" + total;
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

        private void Label_cart_notif_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Cart_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void panel_cart1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = false;
        }

        private void label_Tittle_Click(object sender, EventArgs e)
        {

        }

        private void pictubebox1_library_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel_f_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


