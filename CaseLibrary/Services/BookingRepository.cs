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
    public class BookingRepository : IBookingRepository // We inherit from our IBookingRepository
    {

        private Dictionary<string, Booking> _bookings; // Here we create our dictionary


        public BookingRepository()
        {
            _bookings = MockData.GetBookings();
        }


        /// <summary>
        /// This method takes the parameter booking of type Booking and adds it to our dictionary of Bookings where key is the BookingId and the bookingobject is the value
        /// </summary>
        public void AddBooking(Booking booking)
        {
            _bookings.TryAdd(booking.BookingId, booking);
        }



        /// <summary>
        /// This method takes the paramenter bookingId of type string, that search in the dictionary and if there's a key then it remove the entire <key, value> pair 
        /// </summary>
        /// <param name="bookingId"></param>
        public void DeleteBookingById(string bookingId)
        {
            if (_bookings.Keys.Contains(bookingId))
            {
                _bookings.Remove(bookingId);
            }
        }


        /// <summary>
        /// retuns Bookings dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Booking> GetAllBooking()
        {
            return _bookings;
        }

        

        /// <summary>
        /// This method takes the parameter bookingsId of type string, checks if the given key is present in the dictionary, if true returns the corresponding <key,value> Pair
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
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
