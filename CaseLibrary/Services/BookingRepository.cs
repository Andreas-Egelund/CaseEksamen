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

        public void AddBooking(Booking booking)
        {
            _bookings.TryAdd(booking.BookingId, booking);
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



        public void UpdatebookingById(string bookingId)
        {

            try
            {


                Booking currentBooking = GetBookingById(bookingId);


                Console.WriteLine($"You are editing this booking: \n\n {currentBooking}");

                Console.WriteLine("Do you want to edit the date of the booking?\n" +
                    "(Y)es or (N)o?");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new date here  dd/m/year: \n");
                    currentBooking.Date = Console.ReadLine();
                }



                Console.WriteLine("Do you want to edit the duration of the booking?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new duration in hours here : \n");
                    currentBooking.Duration = Console.ReadLine();
                }




                Console.WriteLine("Do you want to edit the location of the booking?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new location here:\n");
                    currentBooking.Location = Console.ReadLine();
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }















        }
    }
}
