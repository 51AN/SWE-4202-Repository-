using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastMoments
{


    public class teacher
    {

    }

    public class lecturer : teacher
    {

    }

    public class proff : teacher
    {

    }
    internal class Program
    {


        private string idiot;
        public string Idiot { get { return idiot; }set { idiot = value; } }




        public static T add<T>(T a , T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }

        static void Main(string[] args)
        {


            teacher T = new proff();//upcast


            teacher T1 = new teacher();

            lecturer L = (lecturer)T1;//downcast

            Console.WriteLine(add(5, 4));
        }
    }
}
