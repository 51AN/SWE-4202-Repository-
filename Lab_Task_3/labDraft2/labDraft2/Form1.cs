using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labDraft2
{
    public partial class Form1 : Form
    {
        List<BookClass> Book_List= new List<BookClass>();
        List<UserClass> User_List = new List<UserClass>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void showBookButton_Click(object sender, EventArgs e)
        {
            double checkBookIdHistory = Convert.ToDouble(bookHistoryBox.Text);
            bool error = true;
            for(int i=0;i<Book_List.Count;i++)
            {
                if(Book_List[i].checkBook(checkBookIdHistory))
                {
                    bookIdHisBox.Text = Convert.ToString(Book_List[i].getBookID());
                    bookHisNameBox.Text = Book_List[i].getBookname();
                    AuthorHisBook.Text = Book_List[i].getAuthor();  
                    PublisherHisBook.Text = Book_List[i].getPublisher();
                    quantityHisBook.Text = Convert.ToString(Book_List[i].getQuantity());

                    error = false;
                }
            }
            if(error)
            {
                MessageBox.Show("Book does not exist!");
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            bool error = false;

            double book_id = Convert.ToDouble(BookIdBox.Text);
            string book_name = bookNameBox.Text;
            string author = authorBox.Text;
            string publisher = publisherBox.Text;
            double quantity = Convert.ToDouble(quantityBox.Text);
            for (int i = 0; i < Book_List.Count; i++)
            {
                if (Book_List[i].checkBook(book_id))
                {
                    MessageBox.Show("Book Already exists!");

                    error = true;

                    break;
                }
            }
            

            
            
            if (error == false)
            {
                BookClass Temp_Book = new BookClass();

                Temp_Book.setterBook(book_id, book_name, author, publisher, quantity);
                Book_List.Add(Temp_Book);
                MessageBox.Show("Book has been saved!");
            }



        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            double User_id = Convert.ToDouble(userIdBox.Text);
            string user_name = nameBox.Text;
            string adress = adressBox.Text;
            bool error = false;


            for (int i = 0; i < User_List.Count; i++)
            {
                if (User_List[i].checkUser(User_id))
                {
                    MessageBox.Show("User Already exists!");

                    error = true;
                }
            }
            if(error == false)
            {
                UserClass Temp_User = new UserClass();

                Temp_User.setterUser(User_id, user_name, adress);

                User_List.Add(Temp_User);

                MessageBox.Show("User has been saved!");

            }
        }

        private void BorrowBookBUtton_Click(object sender, EventArgs e)
        {
            double checkUserIdFromBorrow = Convert.ToDouble(userIdCheckBox.Text);
            double checkBookIdFromBorrow = Convert.ToDouble(bookIDCheckBox.Text);

            bool userExists = false;
            bool bookExists = false;

            for(int i=0; i<User_List.Count;i++)
            {
                if(User_List[i].checkUser(checkUserIdFromBorrow))
                {
                    userExists = true;
                    break;
                }
            }
            for (int j = 0; j < Book_List.Count; j++)
            {
                if (Book_List[j].checkBook(checkBookIdFromBorrow))
                {
                    bookExists = true;
                    break;

                }
            }

            if(bookExists == false || userExists == false)
            {
                MessageBox.Show("Invalid Input!!");
            }
            else
            {
                foreach(BookClass bookClass in Book_List)
                {
                    if(bookClass.checkBook(checkBookIdFromBorrow))
                    {
                        if(bookClass.quantityNullCheck())
                        {
                            MessageBox.Show("Insufficient Books");
                            break;
                        }
                        bookClass.quantityDecrease();
                        foreach(UserClass userClass in User_List)
                        {
                            if(userClass.checkUser(checkUserIdFromBorrow))
                            {
                                for (int j = 0; j < Book_List.Count; j++)
                                {
                                    if (Book_List[j].checkBook(checkBookIdFromBorrow))
                                    {
                                     

                                        userClass.UserHistoryofBookList.Add(Book_List[j]);
                                    }
                                }
                                //userClass.UserBookHistory_List.Add(checkBookIdFromBorrow);
                                MessageBox.Show("Book has been borrowed!");
                            }
                        }
                    }
                }
            }

        }

        private void showUserButton_Click(object sender, EventArgs e)
        {
            double UserHisID = Convert.ToDouble(userHistorybox.Text);
            UserClass dummyUser = new UserClass();
            bool userExists = false;

            foreach(UserClass user in User_List)
            {
                if(user.checkUser(UserHisID))
                {
                    userExists = true;
                    dummyUser = user;
                    break;
                }
            }

            if(userExists == false)
            {
                MessageBox.Show("User doesn't exist.");
            }
            
                
                userHistoryListBox.Items.Clear();   
                for(int i=0;i<dummyUser.UserHistoryofBookList.Count;i++)
                {
                userHistoryListBox.Items.Add(dummyUser.UserHistoryofBookList[i].bookHistory());
                    /*double book_id = dummyUser.UserHistoryofBookList[i].getBookID();
                    for(int j=0; j<Book_List.Count;j++)
                    {
                        if(Book_List[j].checkBook(book_id))
                        {
                            userHistoryListBox.Items.Add(Book_List[j].bookHistory());
                        }
                    }*/
                }

            

        }
    }
}
