using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlightReservation wiproEmployee = FlightReservation.GetFlightReservationInstance();
            FlightReservation gadgeonEmployee = FlightReservation.GetFlightReservationInstance();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(wiproEmployee.BookSeat());
                Console.WriteLine(gadgeonEmployee.BookSeat());
            }

            Console.ReadKey();
        }
    }
}
