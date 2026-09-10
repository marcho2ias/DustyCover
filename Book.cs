using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace BookStoreProj
{
    public class Book
    {
        public string BookID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public double BuyPrice { get; set; }

        public double RentPrice { get; set; }




        //    public Book(int Rentprice, int BuyPrice, string Name , string Description , string Genre)
        //    {
        //        this.BookID = BookID
        //        this.Rentprice = Rentprice;
        //        this.BuyPrice = BuyPrice;
        //        this.Name = Name;
        //        this.Description = Description;
        //        this.Genre = Genre;
        //    }
        //}

        public class Order
        {
            public string Ordername, CustomerName, BookName;
            public int orderTotal, orderCount;

        }
    }
}
