using System;
using System.Collections.Generic;
using System.Text;

namespace NormalApproach
{
    internal class FlightReservation
    {
        private List<string> seatNumbers = new List<string>();
        private int remainingSeat { get; set; } = 0;

        private int currentSeat { get; set; } = 0;

        public FlightReservation()
        {
            seatNumbers.Add("15A");
            seatNumbers.Add("15B");
            seatNumbers.Add("16A");
            seatNumbers.Add("16B");
            remainingSeat = seatNumbers.Count;
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
