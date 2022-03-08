using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPractice
{
    public class DivideByOddException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Can not devide by odd";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;


           
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
                result = num1 / num2;
            
            if(num2%2==1)
            {
                DivideByOddException ex = new DivideByOddException();
                throw ex;
            }




            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
