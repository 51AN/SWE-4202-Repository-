using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2
{
    internal class UserClass
    {
        private double userid;
        private string name;
        private string address;

        List<string> bookBorrowed = new List<string>();

        public string userHistoryGet(double bookId)
        {
            string setuserHis = userid.ToString() + " " + bookId.ToString();
            return setuserHis;

        }
        public void setterUser(double userID, string name, string adress)
        {
            this.userid = userID;
            this.name = name;
            this.address = adress;

        }

        public bool checkUserId(double UserCheckId)
        {
            if (userid == UserCheckId)
                return true;
            else return false;
        }

    }
}
