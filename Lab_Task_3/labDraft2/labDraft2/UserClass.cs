using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDraft2
{
    internal class UserClass
    {
        private double UserID;
        private string UserName;
        private string Address;

      

        public List<double> UserBookHistory_List = new List<double>();


        BookClass dummyBook = new BookClass();

        
        public void setterUser(double userid, string username, string address)
        {
            this.UserID = userid;
            this.UserName = username;
            this.Address = address; 
        }
        
        public void setterBookinUser(double bookID)
        {
            UserBookHistory_List.Add(bookID);
        }

        public bool checkUser(double UserCheckID)
        {
            if (UserID == UserCheckID)
                return true;
            else return false;
        }
    }
}
