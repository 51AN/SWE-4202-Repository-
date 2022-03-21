using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_2
{
    public partial class Form1 : Form
    {
        List<UserClass> UserList = new List<UserClass>();
        List<BookClass> BookList = new List<BookClass>();
        List<userHistoryClass> userHistoryList = new List<userHistoryClass>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            double userid = Convert.ToDouble(userIdBox.Text);
            string UserName = nameBox.Text;
            string address = adressBox.Text;

            UserClass UserTemp = new UserClass();
            UserTemp.setterUser(userid, UserName, address);
            UserList.Add(UserTemp);
           


        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            double bookId = Convert.ToDouble(BookIdBox.Text);
            string bookName = bookNameBox.Text;
            string author = authorBox.Text;
            string publisher = publisherBox.Text;
            double quantity = Convert.ToDouble(quantityBox.Text);

            BookClass BookTemp = new BookClass();

            BookTemp.setterBook(bookId, bookName, author, publisher, quantity);

            BookList.Add(BookTemp);


        }

        private void showBookButton_Click(object sender, EventArgs e)
        {
            double searchBookId =  Convert.ToDouble(bookHistoryBox.Text);

            bookListBox.Items.Clear();
            for(int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].checkBookId(searchBookId))
                    {
                        bookListBox.Items.Add(BookList[i].BookIdget());
                        bookListBox.Items.Add(BookList[i].BookNameget());
                        bookListBox.Items.Add(BookList[i].authorGet());
                        bookListBox.Items.Add(BookList[i].publisherGet());
                        bookListBox.Items.Add(BookList[i].quantityGet());
                    }
            }

        }

        private void BorrowBookBUtton_Click(object sender, EventArgs e)
        {
            double userIdCheckFromBorrowBook = Convert.ToDouble(userIdCheckBox.Text);
            double bookIdCheckFromBorrowBook = Convert.ToDouble(bookIDCheckBox.Text);

            bool error = true;

            for(int i = 0;i < BookList.Count;i++)
            {
                if(BookList[i].checkBookId(bookIdCheckFromBorrowBook) && UserList[i].checkUserId(userIdCheckFromBorrowBook))
                {
                    userHistoryClass UserHistoryTemp = new userHistoryClass();

                    UserHistoryTemp.setterUserHistory(userIdCheckFromBorrowBook, bookIdCheckFromBorrowBook);
                    
                    userHistoryList.Add(UserHistoryTemp);

                    BookList[i].quantityDecrease();

                    error = false;
                }
            }
            if(error)
            {
                MessageBox.Show("Invalid Input");
            }

        }

        private void showUserButton_Click(object sender, EventArgs e)
        {
            double searchUserId = Convert.ToDouble(userHistorybox.Text);

            userListBox.Items.Clear();
            for (int i = 0; i < userHistoryList.Count; i++)
            {
                if (userHistoryList[i].checkUserIdHistory(searchUserId))
                {
                    userListBox.Items.Add(userHistoryList[i].getUseHistory());
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
