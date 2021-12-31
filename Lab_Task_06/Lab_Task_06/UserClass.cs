using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_06
{
    internal class UserClass : LMS
    {
        private string userID;
        
        public bool checkIfUserExists(string id)
        {
            if (userID == id)
            {
                return true;
            }
            else return false;
        }

        public void setterUser(string userid, string name, string addresss)
        {
            this.userID = userid;
            this.userName = name;
            this.address = addresss;

        }

        public string getName()
        {
            return userName;
        }
        public string getAdress()
        {
            return address;
        }

    }
}
