using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_07
{
    internal class Participant
    {
        public string name;
       
        public bool beginer;
        public bool intermideate;
        public bool advanced;


        public bool checkPartExists(string check)
        {
            if (check == name)
            {
                return true;
            }
            else return false;
        }

    }
}
