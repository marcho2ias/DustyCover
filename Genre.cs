using DustyCover.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookStoreProj.Book;

namespace BookStoreProj
{
    public partial class Genre : Form
    {
        List<Book> books = new List<Book>();
        int cnt = 0;
        double total = 0;
        int cart = 0;

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
        }

        private void label_cartPrice1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = false;
            Panel_Genre.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Panel_faitytale.Visible = true;
            Panel_Genre.Visible = true;
            panel_cart.Visible = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            total = 0;
            cnt = 0;
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

        // ============= BOOK 1 - FIXED =============
        private void btn_buy1_Click_1(object sender, EventArgs e)
        {
            cart++;
            total += books[0].BuyPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label1_Library.Text + "$".PadLeft(5) + books[0].BuyPrice.ToString().PadLeft(6));

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Rent1_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[0].RentPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label1_Library.Text + "$".PadLeft(5) + books[0].RentPrice.ToString().PadLeft(6));

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ============= ANIME BUTTON =============
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

        // ============= MATH BUTTON =============
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

            pictubebox1_library.Image = Image.FromFile("Resources\\Fermats.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\infinity.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\Eternal.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\solved.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\MathIdea.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\ColosalMath.jpg");
        }

        // ============= DICTIONARY BUTTON =============
        private void button8_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;

            books.Clear();

            string filePath = "Resources\\Dictionary.csv";
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
            label6_Library.Text = books[4].Tittle;
            label5_Library.Text = books[5].Tittle;

            label1_price.Text = "Buy Price:" + books[0].BuyPrice.ToString() + " Rent Price :" + books[0].RentPrice.ToString();
            label2_price.Text = "Buy Price:" + books[1].BuyPrice.ToString() + " Rent Price :" + books[1].RentPrice.ToString();
            label3_price.Text = "Buy Price:" + books[2].BuyPrice.ToString() + " Rent Price :" + books[2].RentPrice.ToString();
            label4_price.Text = "Buy Price:" + books[3].BuyPrice.ToString() + " Rent Price :" + books[3].RentPrice.ToString();
            label5_price.Text = "Buy Price:" + books[4].BuyPrice.ToString() + " Rent Price :" + books[4].RentPrice.ToString();
            label6_price.Text = "Buy Price:" + books[5].BuyPrice.ToString() + " Rent Price :" + books[5].RentPrice.ToString();

            pictubebox1_library.Image = Image.FromFile("Resources\\Collegiate.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\Americanheritage.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\oxford.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\chambers.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\Longman.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\Collins.jpg");
        }

        // ============= PSYCHOLOGY BUTTON =============
        private void button9_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;

            books.Clear();

            string filePath = "Resources\\Psychology.csv";
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
            label6_Library.Text = books[4].Tittle;
            label5_Library.Text = books[5].Tittle;

            label1_price.Text = "Buy Price:" + books[0].BuyPrice.ToString() + " Rent Price :" + books[0].RentPrice.ToString();
            label2_price.Text = "Buy Price:" + books[1].BuyPrice.ToString() + " Rent Price :" + books[1].RentPrice.ToString();
            label3_price.Text = "Buy Price:" + books[2].BuyPrice.ToString() + " Rent Price :" + books[2].RentPrice.ToString();
            label4_price.Text = "Buy Price:" + books[3].BuyPrice.ToString() + " Rent Price :" + books[3].RentPrice.ToString();
            label5_price.Text = "Buy Price:" + books[4].BuyPrice.ToString() + " Rent Price :" + books[4].RentPrice.ToString();
            label6_price.Text = "Buy Price:" + books[5].BuyPrice.ToString() + " Rent Price :" + books[5].RentPrice.ToString();

            pictubebox1_library.Image = Image.FromFile("Resources\\Thinking.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\Influence.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\Meaning.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\Emotional.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\Mindset.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\Quiet.jpg");
        }

        // ============= MIX BUTTON =============
        private void button10_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;

            books.Clear();

            string filePath = "Resources\\Mix.csv";
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
            label6_Library.Text = books[4].Tittle;
            label5_Library.Text = books[5].Tittle;

            label1_price.Text = "Buy Price:" + books[0].BuyPrice.ToString() + " Rent Price :" + books[0].RentPrice.ToString();
            label2_price.Text = "Buy Price:" + books[1].BuyPrice.ToString() + " Rent Price :" + books[1].RentPrice.ToString();
            label3_price.Text = "Buy Price:" + books[2].BuyPrice.ToString() + " Rent Price :" + books[2].RentPrice.ToString();
            label4_price.Text = "Buy Price:" + books[3].BuyPrice.ToString() + " Rent Price :" + books[3].RentPrice.ToString();
            label5_price.Text = "Buy Price:" + books[4].BuyPrice.ToString() + " Rent Price :" + books[4].RentPrice.ToString();
            label6_price.Text = "Buy Price:" + books[5].BuyPrice.ToString() + " Rent Price :" + books[5].RentPrice.ToString();

            pictubebox1_library.Image = Image.FromFile("Resources\\afterr.jpg");
            pictubebox2_library.Image = Image.FromFile("Resources\\Project.jpg");
            pictubebox3_library.Image = Image.FromFile("Resources\\Before.jpg");
            pictubebox4_library.Image = Image.FromFile("Resources\\Panic.jpg");
            pictubebox5_library.Image = Image.FromFile("Resources\\IfIstay.jpg");
            pictubebox6_library.Image = Image.FromFile("Resources\\PaperTown.jpg");
        }

        // ============= CART BUTTON HANDLERS - FIXED TOTALS AND PRICES =============

        // BOOK 2 (Index 1) - FIXED
        private void button3_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[1].BuyPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label2_Library.Text + "$".PadLeft(5) + books[1].BuyPrice.ToString().PadLeft(6));  // FIXED: books[1]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cart++;
            total += books[1].RentPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label2_Library.Text + "$".PadLeft(5) + books[1].RentPrice.ToString().PadLeft(6));  // FIXED: books[1]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BOOK 3 (Index 2) - FIXED
        private void button5_Click_2(object sender, EventArgs e)
        {
            cart++;
            total += books[2].BuyPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label3_Library.Text + "$".PadLeft(5) + books[2].BuyPrice.ToString().PadLeft(6));  // FIXED: books[2]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            cart++;
            total += books[2].RentPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label3_Library.Text + "$".PadLeft(5) + books[2].RentPrice.ToString().PadLeft(6));  // FIXED: books[2]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BOOK 4 (Index 3) - FIXED
        private void button11_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[3].BuyPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label4_Library.Text + "$".PadLeft(5) + books[3].BuyPrice.ToString().PadLeft(6));  // FIXED: books[3]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[3].RentPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label4_Library.Text + "$".PadLeft(5) + books[3].RentPrice.ToString().PadLeft(6));  // FIXED: books[3]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BOOK 5 (Index 4) - FIXED
        private void button13_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[4].BuyPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label5_Library.Text + "$".PadLeft(5) + books[4].BuyPrice.ToString().PadLeft(6));  // FIXED: books[4]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[4].RentPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label5_Library.Text + "$".PadLeft(5) + books[4].RentPrice.ToString().PadLeft(6));  // FIXED: books[4]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BOOK 6 (Index 5) - FIXED
        private void button16_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[5].BuyPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label6_Library.Text + "$".PadLeft(5) + books[5].BuyPrice.ToString().PadLeft(6));  // FIXED: books[5]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cart++;
            total += books[5].RentPrice;  // FIXED: Added to total instead of multiplying
            panel_cart.Visible = false;

            listBox_cart.Items.Add(label6_Library.Text + "$".PadLeft(5) + books[5].RentPrice.ToString().PadLeft(6));  // FIXED: books[5]

            label_total.Text = total.ToString();
            label_cart.Text = cart.ToString();

            if (cart <= 1)
            {
                MessageBox.Show("Successfully Added to cart. Please click the cart button below to see all the items on cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ============= OTHER METHODS =============

        private void cart_btn_Click(object sender, EventArgs e)
        {
            Panel_Genre.Visible = true;
            Panel_faitytale.Visible = true;
            panel_cart.Visible = false;
        }

        private void panel_cart_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void btn_clrcart_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to clear the cart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                listBox_cart.Items.Clear();
                cart = 0;
                total = 0;
                label_total.Text = total.ToString();
                label_cart.Text = cart.ToString();
            }
        }

        private void listBox_cart_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel_cart_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_delete_order_Click(object sender, EventArgs e)
        {
            if (listBox_cart.SelectedItem != null)
            {
                DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    listBox_cart.Items.Remove(listBox_cart.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            string order = "";

            foreach (var item in listBox_cart.Items)
            {
                order += item.ToString() + " | ";
            }

            payment Payment = new payment(order, total);
            Payment.ShowDialog();
            this.Close();
        }

        private void Genre_Load(object sender, EventArgs e)
        {

        }
    }
}