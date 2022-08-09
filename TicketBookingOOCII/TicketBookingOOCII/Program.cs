using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingOOCII
{


    public abstract class BookingClass
    {

        public virtual void TicketBooking() { }

    }
    internal class AirBooking : BookingClass
    {
        public override void TicketBooking()
        {
            Console.WriteLine("You have booked a ticket via plane");
        }

    }
    
    internal class BusBooking : BookingClass
    {
        public override void TicketBooking()
        {
            Console.WriteLine("You have booked a ticket via bus");
        }

    }
    internal class TrainBooking : BookingClass
    {
        public override void TicketBooking()
        {
            Console.WriteLine("You have booked a ticket via train");
        }

    }


    public class Agent
    {

        public void Book(BookingClass b)
        {
            
            b.TicketBooking();
        }

        public void BookAir()
        {
            AirBooking airBooking = new AirBooking();
            airBooking.TicketBooking();
        }
        public void BookBus()
        {
            BusBooking busBooking = new BusBooking();
            busBooking.TicketBooking();
        }
        public void BookTrain()
        {
            TrainBooking trainBooking = new TrainBooking();
            trainBooking.TicketBooking();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your prefered travelling method :");
            Console.WriteLine("A for air, B for bus, T for train");

            string check;
            check = Console.ReadLine();
            if (check == "A")
            {
                //Agent agent = new Agent();
                //agent.BookAir();

                Agent agent = new Agent();
                AirBooking airBooking = new AirBooking();
                agent.Book(airBooking);
            }
            else if (check == "B")
            {
                Agent agent = new Agent();
                agent.BookBus();

            }
            else
            {
                Agent agent = new Agent();
                agent.BookTrain();
            }


            Console.ReadKey();

        }
    }
}
