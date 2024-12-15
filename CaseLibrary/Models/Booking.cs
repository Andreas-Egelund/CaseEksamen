using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class Booking
    {
        private static int _nextId = 100;
        private string _bookingId;

        public string BookingId { get => _bookingId; set => _bookingId = value; }
        public Boat BoatBooked { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }



        public Booking(Boat boatBooked, string date, string duration, string location)
        {
            _nextId++;
            _bookingId = $"BK-Id-{_nextId}";
            BoatBooked = boatBooked;
            Date = date;
            Duration = duration;
            Location = location;
        }


        public override string ToString()
        {
            return $"---------------------------------------\n" +
                $"Booking Id: {BookingId}\n" +
                $"Boat booked: {BoatBooked}\n" +
                $"Date for booking: {Date}\n" +
                $"Duration of booking: {Duration}\n" +
                $"Location for booking: {Location}\n" +
                $"---------------------------------------\n";
        }


    }
}
