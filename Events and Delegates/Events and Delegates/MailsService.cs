using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    internal class MailsService
    {
        public void OnStudentAdmitted(object sender, EventArgs e)
        {
            Console.WriteLine("Mail Sent");
        }
        public void Send()
        {
            Console.WriteLine("Mail Sent part 2");
        }
    }
}
