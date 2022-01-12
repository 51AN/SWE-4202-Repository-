using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_006
{
    internal class OrderClass
    {
        private double orderID;
        private string name;
        private string address;
        public string status;
        private double Amount;

        public string getName()
        {
            return name;
        }
        public string getAdd()
        {
            return address;
        }
        public string getAmount()
        {
            return Amount.ToString();
        }
        public string getStatus()
        {
            return status;
        }

        private string shirts;
        private string pants;
        private string suits;
        private string bedSheets;

        private string shirtstd;
        private string pantstd;
        private string suitstd;
        private string bedSheetstd;

        public double sAmount;
        public double pAmoutn;
        public double suAmount;
        public double bsAmount;

        public void setAmounts(double shirt, double pant, double suit, double bed)
        {
            this.sAmount = shirt;
            this.pAmoutn = pant;
            this.suAmount = suit;
            this.bsAmount = bed;

        }
        public OrderClass(double orderid, string name, string address, double amount, string shirt, string suit, string pant, string bedsheet, string std, string ptd, string sutd, string bstd)
        {
            this.orderID = orderid;
            this.name = name;
            this.address = address;
            this.Amount = amount;

            this.shirts = shirt;
            this.pants = pant;
            this.suits = sutd;
            this.bedSheets = bedsheet;

            this.shirtstd = std;
            this.pantstd = ptd;
            this.suitstd = sutd;
            this.bedSheetstd = bstd;

        }

        public bool checkIfOrderExist(double ID)
        {
            if(orderID == ID)
            {
                return true;
            }
            else return false;
        }
        

        public void setStatusDefault()
        {
            this.status = "Pending";
        }

        public string getShirt()
        {
            string set = "Shirt" + "\t" + shirts + "\t" + shirtstd + "\t" + sAmount.ToString();
            return set;
        }

         public string getPant()
        {
            string set = "Pant" + "\t" + pants + "\t" + pantstd + "\t" + pAmoutn.ToString();
            return set;
        }

         public string getSuit()
        {
            string set = "Suit" + "\t" + suits + "\t" + suitstd + "\t" + suAmount.ToString();
            return set;
        }

         public string getBs()
        {
            string set = "Bed S." + " " + bedSheets + "\t" + bedSheetstd + "\t" + bsAmount.ToString();
            return set;
        }



    }
}
