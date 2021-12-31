using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUserOnClick(object sender, EventArgs e)
        {
            string userid = UserIDBox1.Text;
            string name = NameBox.Text;
            string address = AddressBox.Text;

            bool errorExists = false;
            UserClass dummy = new UserClass();

            for(int i = 0;i<LMS.UserList.Count;i++)
            {
                if(LMS.UserList[i].checkIfUserExists(userid))
                {
                    errorExists = true;
                    break;
                }
            }
            if(!errorExists)
            {
                dummy.setterUser(userid,name,address);
                LMS.UserList.Add(dummy);
                MessageBox.Show("User Has Been Added!");
            }
            else
            {
                MessageBox.Show("User Already Exists!");
            }
        }

        private void PlaceOrderOnClick(object sender, EventArgs e)
        {
            string userid = UserIDBox2.Text;
            bool errorExists = true;
            double pants = Convert.ToDouble(dontKnowtheFbox.Text);
            double shirts = Convert.ToDouble(ShirtBox.Text);

            double suits = Convert.ToDouble(SuitBox.Text);
            double bedSheets = Convert.ToDouble(BedSheetBox.Text);

            double amount = 0;

            string ptd = PantcomboBox.Text;
            string std = ShirtcomboBox3.Text;

            string sutd = SuitcomboBox5.Text;
            string btd= BedSheetcomboBox4.Text;
            OrderClass dummyOrder = new OrderClass();
            UserClass dummyUser = new UserClass();
            ItemsClass dummyitems = new ItemsClass();
            int i=0;
            for(i=0;i<LMS.UserList.Count;i++)
            {
                if(LMS.UserList[i].checkIfUserExists(userid))
                {
                    errorExists = false;
                    break;
                }
            }

            if(errorExists)
            {
                MessageBox.Show("Invalid UserID!");
            }

            else
            {
                //pants

                dummyitems.setItems(pants.ToString(), shirts.ToString(), suits.ToString(), bedSheets.ToString(), ptd, std, sutd, btd);
                dummyOrder.ItemsList.Add(dummyitems); 

            if(ptd == "Wash")
                {
                    amount += pants * 10;
                }
                else if(ptd == "Iron")
                {
                    amount += pants * 5;
                }
                else
                {
                    amount += pants * 12;
                }

            if(std == "Wash")
                {
                    amount += shirts * 10;
                }
                else if(std == "Iron")
                {
                    amount += shirts * 5;
                }
                else
                {
                    amount += shirts * 12;
                }

            if(sutd == "Wash")
                {
                    amount += suits * 10;
                }
                else if(sutd == "Iron")
                {
                    amount += suits * 5;
                }
                else
                {
                    amount += suits * 12;
                }

            if(btd == "Wash")
                {
                    amount += bedSheets * 10 ;
                }
                else if(btd == "Iron")
                {
                    amount += bedSheets * 5  ;
                }
                else
                {
                    amount += bedSheets * 12 ;
                }








                LMS.CurrentBalance += amount;
                
                dummyOrder.setterOrder(LMS.OrderID.ToString(), LMS.UserList[i].getName(), LMS.UserList[i].getAdress(), "Pending",amount.ToString());
                LMS.OrderList.Add(dummyOrder);
                MessageBox.Show("Order has been placed!\nYour order ID is " + LMS.OrderID.ToString());
                ++LMS.OrderID;

            }


            
            


        }

        private void SetStatusOnClick(object sender, EventArgs e)
        {
            string orderid = OrderIDOwnerBox.Text;
            bool errorExists = true;
            int i = 0;
            for(i=0;i<LMS.OrderList.Count;i++)
            {
                if(LMS.OrderList[i].checkIfOrderExist(orderid))
                {
                    errorExists = false;
                    break;
                }
            }

            if(errorExists)
            {
                MessageBox.Show("Order doesn't exist!");
            }
            else
            {
                LMS.OrderList[i].setStatus(OrderStatuscomboBox6.Text);
                UpdateCurrentBlaanceLabel.Text = LMS.CurrentBalance.ToString(); 
                MessageBox.Show("Status has been updated!");
            }


        }

        private void seeorderdetailsOnClick(object sender, EventArgs e)
        {
            string orderid = OrderIDOwnerBox.Text;
            bool errorExists = true;
            int i = 0;
            for (i = 0; i < LMS.OrderList.Count; i++)
            {
                if (LMS.OrderList[i].checkIfOrderExist(orderid))
                {
                    errorExists = false;
                    break;
                }
            }

            if (errorExists)
            {
                MessageBox.Show("Order doesn't exist!");
            }

            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(LMS.OrderList[i].ItemsList[0].getItems());

                UpdateStatusLabel.Text = LMS.OrderList[i].getStatus();
                UpdateACcountLabel.Text = LMS.OrderList[i].getAmount();
                UpdateNameLavel.Text = LMS.OrderList[i].getName();
                UpdateAddLabel.Text = LMS.OrderList[i].getAddress();
            }

        }
    }
}
