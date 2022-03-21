using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2
{
    internal class BookClass
    {
       private double bookid;
       private string bookName;
       private string author;
        private string publisher;
        private double quantity;

       

        public double BookIdget()
        {
            return bookid;
        }

        public string BookNameget()
        {
            return bookName;
        }

        public string authorGet()
        {
            return author;
        }

        public string publisherGet()
        { return publisher;}
        public double quantityGet()
        {
            return quantity;
        }

        public bool checkBookId(double BookCheckId)
        {
            if(bookid == BookCheckId)
                return true;
            else return false;
        }
        public void setterBook(double bookId, string bookname, string author, string publisher, double quantity)
        {
            this.bookid = bookId;
            this.bookName = bookname;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;

        }

        public void quantityDecrease()
        {
            this.quantity = quantity - 1;
        }
    }
}
