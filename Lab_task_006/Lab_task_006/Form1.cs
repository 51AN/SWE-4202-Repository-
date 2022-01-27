using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserOnClick(object sender, EventArgs e)
        {
            string userid = UserIDBox1.Text;
            string name = NameBox.Text;
            string address = AddressBox.Text;
            bool errorExists = false;
            for(int i=0;i < LMS.userList.Count;i++)
            {
                if(LMS.userList[i].CheckIfUserExists(userid))
                {
                    errorExists = true;
                    break;
                }
            }
            if(errorExists)
            {
                MessageBox.Show("User Already Exists!");
            }
            else
            {
                UserClass user = new UserClass(userid, name, address);

                

                LMS.userList.Add(user);
                MessageBox.Show("User Has Been Added");
            }

        }

        private void placeOrderOnClick(object sender, EventArgs e)
        {
            string userid = UserIDBox2.Text;
            int i;
            bool errorExists = true;

            for (i = 0; i < LMS.userList.Count; i++)
            {
                if (LMS.userList[i].CheckIfUserExists(userid))
                {
                    errorExists = false;
                    break;
                }
            }


            if( errorExists)
            {
                MessageBox.Show("User Doesn't Exist!");

            }
            else
            {


                string name = LMS.userList[i].getName();
                string address = LMS.userList[i].getAdd();

                double shirts = Convert.ToDouble(ShirtBox.Text);
                double pants = Convert.ToDouble(dontKnowtheFbox.Text);
                double suits = Convert.ToDouble(SuitBox.Text);
                double bedSheets = Convert.ToDouble(BedSheetBox.Text);

                string std = ShirtcomboBox3.Text;
                string ptd = PantcomboBox.Text;
                string sutd = SuitcomboBox5.Text;
                string btd = BedSheetcomboBox4.Text;


                double sAmount;
                double pAmount;
                double suAmount;
                double bsAmount;

                if(std == "Wash")
                {
                    sAmount = 5 * 2 * shirts;
                }
                else if(std == "Iron")
                {
                    sAmount=5 * 3 * shirts;
                }
                else
                {
                    sAmount = 5 * 4 * shirts;
                }

                if(ptd == "Wash")
                {
                    pAmount = 7 * 2 * pants;
                }
                else if(ptd == "Iron")
                {
                    pAmount= 7 * 3 * pants;
                }
                else
                {
                    pAmount = 7 * 4 * pants;
                }

                if(sutd == "Wash")
                {
                    suAmount = 10 * 2 * suits;
                }
                else if(sutd == "Iron")
                {
                    suAmount= 10 * 3 * suits;
                }
                else
                {
                    suAmount = 10 * 4 * suits;
                }

                if(btd == "Wash")
                {
                    bsAmount = 15 * 2 *bedSheets;
                }
                else if(btd == "Iron")
                {
                    bsAmount= 15 * 3 * bedSheets;
                }
                else
                {
                    bsAmount = 15 * 4 * bedSheets;
                }

                    
                double totalamount = sAmount + suAmount + pAmount + bsAmount;

                OrderClass dummyOrder = new OrderClass(LMS.orderNo, name, address, totalamount, shirts.ToString(), pants.ToString(), suits.ToString(), bedSheets.ToString(), std, ptd, sutd, btd);
                dummyOrder.setAmounts(sAmount,pAmount,suAmount,bsAmount);
                dummyOrder.setStatusDefault();
                OwnerClass.currentBalance += totalamount;
                LMS.orderList.Add(dummyOrder);
                MessageBox.Show("Order Has Been Added!\nOrder no : " + LMS.orderNo.ToString());
                ++LMS.orderNo;

            }
        }

        private void setStatusOnclick(object sender, EventArgs e)
        {
            string orderID = OrderIDOwnerBox.Text;
            int i = 0;
            bool errorExists = true;

            for(i=0;i<LMS.orderList.Count;i++)
            {
                if(LMS.orderList[i].checkIfOrderExist(Convert.ToDouble(orderID)))
                {
                    errorExists = false;
                    LMS.orderList[i].status = OrderStatuscomboBox6.Text;
                    UpdateCurrentBlaanceLabel.Text = OwnerClass.currentBalance.ToString();

                    
                    break;

                }
            }
            if(errorExists)
            {
                MessageBox.Show("Order doesn't exist!");
            }
        }

        private void seeOrderDetails(object sender, EventArgs e)
        {
            double orderID = Convert.ToDouble(OrderIDCheckBox.Text);

            bool errorExists = true;
            int i = 0; 
            for (i = 0; i < LMS.orderList.Count; i++)
            {
                if (LMS.orderList[i].checkIfOrderExist(Convert.ToDouble(orderID)))
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
                UpdateStatusLabel.Text = LMS.orderList[i].getStatus();
                UpdateNameLavel.Text = LMS.orderList[i].getName();
                UpdateAddLabel.Text = LMS.orderList[i].getAdd();
                UpdateACcountLabel.Text = LMS.orderList[i].getAmount();


                listBox1.Items.Clear();

                listBox1.Items.Add("Type" + "\t" + "Quantity" + "\t" + "To_do" + "\t" + "Amount");

                listBox1.Items.Add(LMS.orderList[i].getPant());
                listBox1.Items.Add(LMS.orderList[i].getShirt());
                listBox1.Items.Add(LMS.orderList[i].getSuit());
                listBox1.Items.Add(LMS.orderList[i].getBs());

            }
        }
    }
}
