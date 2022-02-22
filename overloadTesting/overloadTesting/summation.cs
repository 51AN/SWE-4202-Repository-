using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadTesting
{
    public class summation
    {

        private string name;
        public string Name { get { return name; } set { name = value; } }

        public double ammount;
        public double Amount { get; set; }


        public void summi(double a, double b)
        {

        }

        public void summi(double a, double b, double c)
        {

        }

    }
}
