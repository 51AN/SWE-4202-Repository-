using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    internal class SMSservice
    {
        public void OnStudentAdmitted(object sender, EventArgs e)
        {
            Console.WriteLine("SMS Sent");
        }
        public void Send()
        {

        }
    }
}
