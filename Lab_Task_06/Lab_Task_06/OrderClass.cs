using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_06
{
    internal class OrderClass :LMS
    {

        public List<ItemsClass> ItemsList = new List<ItemsClass>();
        
        private string orderID;
        private string status;
        
        private string Amount;

        public void setStatus(string status)
            { this.status = status; }

        public string getStatus()
        {
            return this.status;
        }
        public string getName()
        {
            return this.userName;
        }
        public string getAddress()
        {
            return this.address;
        }
        public string getAmount()
        {
            return this.Amount;
        }

        public bool checkIfOrderExist(string id)
        {
            if(id == orderID)
                return true;
            else return false;
        }

        public void setterOrder(string oderid, string username, string adress, string status, string amount)
        {
            this.orderID = oderid;   
            this.userName = username;
            this.address = adress;
            this.status = status;
            this.Amount = amount;
        }
            
    }
}
