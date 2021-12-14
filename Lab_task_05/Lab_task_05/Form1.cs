using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_05
{
    public partial class Form1 : Form
    {
        List<MedicineClass> MedicineList = new List<MedicineClass>();

        double TotalBalance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addMedOnClick(object sender, EventArgs e)
        {
            double IDAdd = Convert.ToDouble(MedIdBox.Text);
            string nameADD = MedNameBox.Text;
            double quantityADD = Convert.ToDouble(MedQuanBox.Text);
            double priceADD = Convert.ToDouble(MedPriceBox.Text);

            bool medExists = false;
            int i = 0;
            for(i =0;i<MedicineList.Count;i++)
            {
                if(MedicineList[i].checkMedID(IDAdd))
                {
                    MedicineList[i].quantityIncrease(quantityADD);
                    MessageBox.Show("Meicine Exists and Quantity of it has been increased!");
                    medExists = true;
                    break;
                }    
            }

            if(medExists==false)
            {
                MedicineClass TempMed = new MedicineClass();
                TempMed.setterMed(IDAdd,nameADD,quantityADD,priceADD);
                MedicineList.Add(TempMed);
                comboBox1.Items.Add(TempMed);
                MessageBox.Show("Medicine Added!");

            }
            
        }

        private void medSHOWonClick(object sender, EventArgs e)
        {
            double CheckMedID = Convert.ToDouble(MedSHOWidBox.Text);

            bool medExist = false;

            foreach(MedicineClass Medicine in MedicineList)
            {
                if(Medicine.checkMedID(CheckMedID))
                {
                    MedicineListBox.Items.Clear();
                    MedicineListBox.Items.Add(Medicine.getterInfo());
                    medExist = true;
                    break;
                }
            }
            if(medExist == false)
            {
                MessageBox.Show("Medcine Does Not Exist!!!");
            }

        }

        private void sellMedOnClick(object sender, EventArgs e)
        {
            double IDSell = Convert.ToDouble(MedSELLidBox.Text);
            double QuantitySell = Convert.ToDouble(MedSELLQuantityBox.Text);
            
            bool medExists = false;
            int i = 0;
            for (i = 0; i < MedicineList.Count; i++)
            {
                if (MedicineList[i].checkMedID(IDSell))
                {
                    if(MedicineList[i].quantityCheck(QuantitySell))
                    {
                        MedicineList[i].quantityDecrease(QuantitySell);
                        TotalBalance += MedicineList[i].priceGive()*QuantitySell;
                        MessageBox.Show("Medicine Sold!");
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Medicine!!");
                        medExists = true;
                        break;
                    }
                    medExists = true;
                    break;
                }
            }
            if(medExists == false)
            {
                MessageBox.Show("Medicine Does not Exist!");
            }



        }

        private void ShowBalanceOnClik(object sender, EventArgs e)
        {
            CurrentAccBalance.Text = Convert.ToString(TotalBalance);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
