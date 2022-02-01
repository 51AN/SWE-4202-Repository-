using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_8
{
    internal class SavingsAcc : AccountClass
    {
        public double transLimit = 5;

        public bool checkLimit()
        {
            if(transLimit == 0)
                return false;
            else return true;
        }
    }
}
