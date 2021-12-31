using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_06
{
    internal class LMS
    {
        public string userName;
        public string address;

        static public List<UserClass> UserList = new List<UserClass>();
        static public List<OrderClass> OrderList = new List<OrderClass>();


        static public double OrderID = 0;

        static public double CurrentBalance = 0; 

        
    }
}
