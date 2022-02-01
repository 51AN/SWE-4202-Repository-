using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_8
{
    internal class LoacAcc : AccountClass 
    {
        public void interest(double amm)
        {
            amm += (amm * (9 / 100));
        }
    }
}
