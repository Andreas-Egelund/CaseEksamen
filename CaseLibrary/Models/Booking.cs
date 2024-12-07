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
        public string BookingId { get; set; }
        public User User { get; set; }
        public Boat BoatBooked { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }



        public Booking(string bookingId, User user,Boat boatBooked, string date, string duration, string location)
        {
            BookingId = bookingId;
            User = user;
            BoatBooked = boatBooked;
            Date = date;
            Duration = duration;
            Location = location;
            
        }





    }
}
