using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
