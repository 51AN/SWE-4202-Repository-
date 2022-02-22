using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        internal class DivideOddException : ApplicationException
        {
            public override string Message
            {
                get {
                    return "Don't divide by odd";
                    }
            }
        }
        static void Main(string[] args)
        {
            int num1, num2, result = 0;

            try
            {
                 num1 = Convert.ToInt32(Console.ReadLine());
                 num2 = Convert.ToInt32(Console.ReadLine());
                 if(num2%2 == 1)
                 {
                    throw new DivideOddException();
                 }
                 result = num1 / num2;

            }
            catch (DivideOddException ex)
            {
                result = 0;
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {

            }
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
