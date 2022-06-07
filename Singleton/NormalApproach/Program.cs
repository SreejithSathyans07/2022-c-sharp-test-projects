using System;

namespace NormalApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlightReservation wiproEmployee = new FlightReservation();
            FlightReservation gadgeonEmployee = new FlightReservation();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(wiproEmployee.BookSeat());
                Console.WriteLine(gadgeonEmployee.BookSeat());
            }

            Console.ReadKey();
        }
    }
}
