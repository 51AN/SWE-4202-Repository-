using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_07
{
    internal class Student:Participant
    {
        public void setterStu(string name,bool begin, bool inter, bool advance)
        {
            this.name = name;
            this.beginer = begin;
            this.advanced = advance;
            this.intermideate = inter;
        }
        public string fee(double fees)
        {
            string set = Convert.ToString(fees);
            return set;
        }
    }
}
