using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{

    interface paraMeth
    {
        bool validate(string a);
    }


    public class stimulate : paraMeth
    {
        string bruh;

        public bool validate(string x)
        {
            if (x == bruh)
                return false;
            else
                return true;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
