using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDraft2
{
    internal class BookClass
    {
        private double BookId;
        private string BookName;
        private string Author;
        private string Publisher;
        private double quantity;

        public bool checkBook(double bookID)
        {
            if(BookId == bookID)
                return true;
            else return false;
        }
        public double getBookID()
        {
            return BookId;
        }
        public string getBookname()
        {
            return BookName;
        }

        public string getAuthor()
        {
            return Author;
        }

        public string getPublisher()
        {
            return Publisher;

        }

        public double getQuantity()
        {
            return quantity;
        }

        public bool quantityNullCheck()
        {
            if(quantity == 0)
                return true;
            else return false;
        }
        public void quantityDecrease()
        {
            this.quantity = quantity-1;
        }

        public void setterBook(double bookid, string bookname, string author, string publisher, double quantity)
        {
            this.BookId = bookid;  
            this.BookName = bookname;
            this.Author = author;
            this.Publisher = publisher;
            this.quantity = quantity;

        }
        public void setterBookforUser(double bookid, string bookname)
        {
            this.BookId = bookid;
            this.BookName = bookname;
            

        }

        public void setterBookHistory(double bookid, string bookname)
        {
            this.BookId = bookid;
            this.BookName = bookname;
        }
        

        public string bookHistory()
        {
            string setBook = BookId.ToString() + " " + BookName;
            return setBook;
        }

    }
}
