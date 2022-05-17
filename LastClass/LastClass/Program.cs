using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace LastClass
{




    public class student
    {
        public int id;
        public string name;
    }

    public class MailsService
    {
        public void OnStudentAdmitted(object sender, EventArgs e)
        {
            Console.WriteLine("Mail Sent");
        }
        public void Send()
        {
            Console.WriteLine("Mail Sent");
        }
    }

    public class SMSservice
    {
        public void OnStudentAdmitted(object sender, EventArgs e)
        {
            Console.WriteLine("SMS Sent");
        }
        public void Send()
        {
            
        }
    }


    public class StudentAdmission
    {

        public delegate void StudentAdmittedEventHandler(object sender , EventArgs e);
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


    public class StudentEventArgs : EventArgs
    {
        string mail, phoneNo;
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            student student = new student();
            student.name = "Sian";
            student.id = 51;

            MailsService ms = new MailsService();
            SMSservice sms = new SMSservice();
            StudentAdmission studentAdmission = new StudentAdmission();

            studentAdmission.StudentAdmitted += ms.OnStudentAdmitted;
            studentAdmission.StudentAdmitted += sms.OnStudentAdmitted;


            
            studentAdmission.Admit(student);

            Console.ReadKey();



        }
    }
}
