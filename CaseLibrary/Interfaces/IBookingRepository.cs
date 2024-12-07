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

        void AddBooking(int bookingId, Booking booking);

        Dictionary<int, Booking> GetAllBooking();

        Booking GetBookingById(int bookingId);

        void UpdatebookingById(int bookingId);

        void DeleteBookingById(int bookingId);


    }
}
