using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_07
{
    internal class Professional:Participant
    {
        public void setterPro(string name, bool begin, bool inter, bool advance)
        {
            this.name = name;
            this.beginer = begin;
            this.advanced = advance;
            this.intermideate = inter;
        }


        public string fee(double fees)
        {
            string set = Convert.ToString(fees+(fees*0.1));
            return set;
        }
    }
}
