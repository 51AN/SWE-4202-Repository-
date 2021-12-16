using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_05
{
    internal class MedicineClass
    {
        private double id;
        private string name;
        private double quantity;
        private double price;

        public string nameGiveForComboBox()
        {
            return name;
        }
        public double priceGive()
        {
            return price;
        }
        
        public void setterMed(double ID, string name, double quantity, double price)
        {
            this.id = ID;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public string getterInfo()
        {
            string get = id.ToString() + "\t  " + name + "\t  " + quantity.ToString() + "\t  " + price.ToString();
            return get;
        }
        public bool checkMedName(string MedName)
        {
            if (MedName == name)
            {
                return true;
            }
            else return false;
        }
        public bool quantityCheck(double QUANtity)
        {
            if (quantity >= QUANtity)
                return true;
            else return false;
        }
        public void quantityDecrease(double QUANtity)
        {
            quantity -= QUANtity;

        }
        public void quantityIncrease(double QUANtity)
        {
            quantity += QUANtity;

        }

    }
}
