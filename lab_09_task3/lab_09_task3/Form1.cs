using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_09_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cow dummycow = new Cow(textBox1.Text, textBox2.Text, "", Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text));

           

            dummycow.Age = Convert.ToInt32(textBox5.Text);

            listBox1.Items.Add(dummycow.getInformation());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat dummycow = new Cat(textBox10.Text, textBox9.Text, "", Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
            

            dummycow.Age = Convert.ToInt32(textBox6.Text);

            listBox2.Items.Add(dummycow.getInformation());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chicken dummycow = new Chicken(textBox15.Text, textBox14.Text, "", Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox12.Text));

            dummycow.Age = Convert.ToInt32(textBox11.Text);

            listBox3.Items.Add(dummycow.getInformation());
        }
    }
}
