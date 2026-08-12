using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DustyCover
{
    internal class BorrowController
    {
        private List<BorrowedBook> books;

        public BorrowController()
        {
            books = new List<BorrowedBook>();

            // Sample data - replace with real data once this is connected to login
            books.Add(new BorrowedBook("Atomic Habits", "12 Aug", "Active", ""));
            books.Add(new BorrowedBook("The Courage to Be Disliked", "8 Aug", "Overdue", ""));
            books.Add(new BorrowedBook("The Art of Winning", "", "Returned", "2 Aug"));
        }

        public List<BorrowedBook> GetAllBooks()
        {
            return books;
        }

        // filter can be "All", "Active", "Overdue", or "Returned"
        public List<BorrowedBook> GetBooksByStatus(string filter)
        {
            if (filter == "All")
            {
                return books;
            }

            List<BorrowedBook> filteredList = new List<BorrowedBook>();

            foreach (BorrowedBook book in books)
            {
                if (book.Status == filter)
                {
                    filteredList.Add(book);
                }
            }

            return filteredList;
        }
    }
}
