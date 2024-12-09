using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Services
{
    public class BookingRepository : IBookingRepository
    {

        private Dictionary<string, Booking> _bookings;


        public BookingRepository()
        {
            _bookings = MockData.GetBookings();
        }

        public void AddBooking(string bookingId, Booking booking)
        {
            _bookings.TryAdd(bookingId, booking);
        }

        public void DeleteBookingById(string bookingId)
        {
            if (_bookings.Keys.Contains(bookingId))
            {
                _bookings.Remove(bookingId);
            }
        }

        public Dictionary<string, Booking> GetAllBooking()
        {
            return _bookings;
        }

        public Booking GetBookingById(string bookingId)
        {
            if (_bookings.ContainsKey(bookingId))
            {
                return (_bookings[bookingId]);
            }
            else return null;
        }



        //TODO This Method is not working as intended. Will overwrite the Booking with given key to have a value of each element until last element in dictionary, resulting in always overwriting given key,valuePair with last element of dict.
        public void UpdatebookingById(string bookingId)
        {

            

        }
    }
}
