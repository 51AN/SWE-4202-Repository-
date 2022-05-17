using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
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
