using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2
{
    internal class userHistoryClass
    {
        public double userID;
        public double bookID;

        public string getUserHistory()
        {
            string setuserHis = userID.ToString() + " " + bookID.ToString();
            return setuserHis;
        }

        public void setterUserHistory(double userId, double bookId)
        {
            this.userID = userId;
            this.bookID = bookId;   
        }

        public bool checkUserIdHistory(double BookCheckId)
        {
            if (userID == BookCheckId)
                return true;
            else return false;
        }

        public string getUseHistory()
        {
            string tempHis = userID.ToString() + "      " + bookID.ToString();
            return tempHis;
        }
    }
}
