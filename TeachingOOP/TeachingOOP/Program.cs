using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingOOP
{
    public class Calculator
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Adder adder = new Adder();


            Console.WriteLine("Summation of first two integers : " + adder.add(a, b));
            Console.WriteLine("Summation of three integers : " + adder.add(a, b, c));
            Console.ReadKey();

        }
    }

    public class Adder
    {
        
        public Adder()
        {
            
        }

        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }



           
    }








}
