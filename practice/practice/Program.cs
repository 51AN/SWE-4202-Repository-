using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInheritanceUsingInheritance
{

    interface bruhInt
    { 
    }
    interface vehicle
    {
        void drive();
    }

    interface truck
    {
        void drive();
    }

    class bruh : vehicle , truck , bruhInt
    {
        public void drive()
        {
            Console.WriteLine("bruh");
        }

    }

    public class Vehicle: vehicle
    {
        public void drive()
        {
            Console.WriteLine("Vehicle");
        }
    }
    public class constructTruck : Vehicle, truck 
    {
        //base class to only inherit from interface
        
        void truck.drive()
        {
            Console.WriteLine("Truck");
        }
    }

    public class biTruck : constructTruck
    {
        

    }
    internal class Program 
    {
        static void Main(string[] args)
        {

            biTruck dummy = new biTruck();

            constructTruck CT = new constructTruck();

            ((vehicle)CT).drive();
            ((truck)CT).drive();
            
            
            
            Console.ReadKey();
        }
    }
}
