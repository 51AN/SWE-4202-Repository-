﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_8
{
    internal class Transactions
    {

        public string type;
        public double amount;


        public string getter()
        {
            string set = type + "\t" + amount.ToString();
            return set;
        }

    }
}
