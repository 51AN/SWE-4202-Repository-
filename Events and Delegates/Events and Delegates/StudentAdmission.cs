using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events_and_Delegates
{
    internal class StudentAdmission
    {
        public delegate void StudentAdmittedEventHandler(object sender, EventArgs e);
        public event StudentAdmittedEventHandler StudentAdmitted;

        public void Admit(student student)
        {
            Console.WriteLine("Admitting Student");
            Thread.Sleep(1000);
            //MailsService mailsService = new MailsService();
            //SMSservice smsService = new SMSservice();
            //mailsService.Send();
            //smsService.Send();
            OnStudentAdmitted();
        }
        protected virtual void OnStudentAdmitted()
        {
            if (StudentAdmitted != null)
            {
                StudentAdmitted(this, EventArgs.Empty);
                // StudentAdmittedEventHandler studentAdmittedEventHandler = (StudentAdmittedEventHandler)StudentAdmitted;
            }
        }
    }
}
