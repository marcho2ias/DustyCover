using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DustyCover
{
    internal class BorrowedBook
    {
        public string Title;
        public string DueDate;
        public string Status;       // "Active", "Overdue", or "Returned"
        public string ReturnDate;

        public BorrowedBook(string title, string dueDate, string status, string returnDate)
        {
            Title = title;
            DueDate = dueDate;
            Status = status;
            ReturnDate = returnDate;
        }

        // Returns the text to show under the title
        public string GetStatusText()
        {
            if (Status == "Active")
            {
                return "Due " + DueDate;
            }
            else if (Status == "Overdue")
            {
                return "Overdue - was due " + DueDate;
            }
            else
            {
                return "Returned " + ReturnDate;
            }
        }

        // Returns the text to show on the action button
        public string GetActionText()
        {
            if (Status == "Active")
            {
                return "Renew";
            }
            else if (Status == "Overdue")
            {
                return "Return";
            }
            else
            {
                return "Borrow again";
            }
        }
    }
}
