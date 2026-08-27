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
using BookStoreProj.Properties;

namespace BookStoreProj
{

    public partial class Genre : Form


    {
       
        List<Book> books = new List<Book>();



        int cnt = 0;
        int total = 0;



        public Genre()
        {
            InitializeComponent();

            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = false;
            panel_cart.Visible = false;

           

           


        }

        private void Panel_Genre_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;

            books.Clear();


            string filePath = "Resources\\Fairytale.csv";

            string[] lines = File.ReadAllLines(filePath);
            


            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

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
            label6_Library.Text = books[5].Tittle;

            label1_price.Text = "Buy Price:" + books[0].BuyPrice.ToString() + " Rent Price :" + books[0].RentPrice.ToString();
            label2_price.Text = "Buy Price:" + books[1].BuyPrice.ToString() + " Rent Price :" + books[1].RentPrice.ToString();
            label3_price.Text = "Buy Price:" + books[2].BuyPrice.ToString() + " Rent Price :" + books[2].RentPrice.ToString();
            label4_price.Text = "Buy Price:" + books[3].BuyPrice.ToString() + " Rent Price :" + books[3].RentPrice.ToString();
            label5_price.Text = "Buy Price:" + books[4].BuyPrice.ToString() + " Rent Price :" + books[4].RentPrice.ToString();
            label6_price.Text = "Buy Price:" + books[5].BuyPrice.ToString() + " Rent Price :" + books[5].RentPrice.ToString();



            pictubebox1_library.Image = Image.FromFile("Resources\\Lordoftherings.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\gamesofthrone.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\TheEarthseaQuartet.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\Jonathan.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\TheGunslinger.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\Callofthemaze.jpg");










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
            panel_cart.Visible = true;
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

        private void btn_buy1_Click_1(object sender, EventArgs e)
        {

            
           
            panel_cart.Visible = false;

            listBox_cart.Items.Add(
                label1_Library.Text);
        }

     
        private void btn_Anime_Click_1(object sender, EventArgs e)
        {

            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;


            books.Clear();



            string filePath = "Resources\\Anime.csv";

            string[] lines = File.ReadAllLines(filePath);



            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                //if (data.Length < 6)
                //    continue; // skip malformed/incomplete lines

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
            label6_Library.Text = books[4].Tittle;
            label5_Library.Text = books[5].Tittle;

            label1_price.Text = "Buy Price:" + books[0].BuyPrice.ToString() + " Rent Price :" + books[0].RentPrice.ToString();
            label2_price.Text = "Buy Price:" + books[1].BuyPrice.ToString() + " Rent Price :" + books[1].RentPrice.ToString();
            label3_price.Text = "Buy Price:" + books[2].BuyPrice.ToString() + " Rent Price :" + books[2].RentPrice.ToString();
            label4_price.Text = "Buy Price:" + books[3].BuyPrice.ToString() + " Rent Price :" + books[3].RentPrice.ToString();
            label5_price.Text = "Buy Price:" + books[4].BuyPrice.ToString() + " Rent Price :" + books[4].RentPrice.ToString();
            label6_price.Text = "Buy Price:" + books[5].BuyPrice.ToString() + " Rent Price :" + books[5].RentPrice.ToString();


            pictubebox1_library.Image = Image.FromFile("Resources\\DemonSlayer.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\BloomIntoYou.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\attackontitan.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\Ajin.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\Blame.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\AgirlonShore.jpg");

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;


            books.Clear();



            string filePath = "Resources\\Math.csv";

            string[] lines = File.ReadAllLines(filePath);



            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                //if (data.Length < 6)
                //    continue; // skip malformed/incomplete lines

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
            label6_Library.Text = books[4].Tittle;
            label5_Library.Text = books[5].Tittle;

            label1_price.Text = "Buy Price:" + books[0].BuyPrice.ToString() + " Rent Price :" + books[0].RentPrice.ToString();
            label2_price.Text = "Buy Price:" + books[1].BuyPrice.ToString() + " Rent Price :" + books[1].RentPrice.ToString();
            label3_price.Text = "Buy Price:" + books[2].BuyPrice.ToString() + " Rent Price :" + books[2].RentPrice.ToString();
            label4_price.Text = "Buy Price:" + books[3].BuyPrice.ToString() + " Rent Price :" + books[3].RentPrice.ToString();
            label5_price.Text = "Buy Price:" + books[4].BuyPrice.ToString() + " Rent Price :" + books[4].RentPrice.ToString();
            label6_price.Text = "Buy Price:" + books[5].BuyPrice.ToString() + " Rent Price :" + books[5].RentPrice.ToString();


            pictubebox1_library.Image = Image.FromFile("Resources\\DemonSlayer.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\BloomIntoYou.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\attackontitan.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\Ajin.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\Blame.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\AgirlonShore.jpg");

        }
    }
    }
    


