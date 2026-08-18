using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProj
{
   public  class Book
    {
        public string Name, Description, Genre;
        public int Rentprice, BuyPrice;

        public Book(int Rentprice, int BuyPrice, string Name , string Description , string Genre)
        {
            this.Rentprice = Rentprice;
            this.BuyPrice = BuyPrice;
            this.Name = Name;
            this.Description = Description;
            this.Genre = Genre;
        }
    }

    public class Order
    {
        public string Ordername, CustomerName, BookName;
        public int orderTotal, orderCount;

    }
}
