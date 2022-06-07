using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class FlightReservation
    {
        private static readonly FlightReservation _instance = new FlightReservation();
        private List<string> seatNumbers = new List<string>();
        private int remainingSeat { get; set; } = 0;

        private int currentSeat { get; set; } = 0;

        private FlightReservation()
        {
            seatNumbers.Add("15A");
            seatNumbers.Add("15B");
            seatNumbers.Add("16A");
            seatNumbers.Add("16B");
            remainingSeat = seatNumbers.Count;
        }

        public static FlightReservation GetFlightReservationInstance()
        {
            return _instance;
        }
        public string BookSeat()
        {
            if (currentSeat == seatNumbers.Count)
            {
                return "No seats available";
            }
            string seatNo =seatNumbers[currentSeat];
            remainingSeat -= 1;
            currentSeat += 1;
            return $"You've reserved the seat {seatNo}";

        }
    }
}
