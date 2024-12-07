using CaseLibrary.Entities;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.interfaces
{
    public interface IBookingRepository
    {

        void AddBooking(string bookingId, Booking booking);

        Dictionary<string, Booking> GetAllBooking();

        Booking GetBookingById(string bookingId);

        void UpdatebookingById(string bookingId);

        void DeleteBookingById(string bookingId);


    }
}
