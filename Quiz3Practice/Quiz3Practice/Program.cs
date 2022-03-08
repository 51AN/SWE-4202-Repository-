using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3Practice
{

    interface vehicle
    {
        void name();

    }


    public class VMS
    {
        public static List<truck> truckList = new List<truck>();
    }



    static class inventory
    {
        public static void Show()
        {
            Console.WriteLine("Inventory has been accessed");
        }
    }
    public class truck : vehicle
    {
        
        public void name()
        {
            Console.WriteLine("I am truck-kun");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            truck truck = new truck();
            truck.name();

            Console.ReadKey();
        }
    }
}
