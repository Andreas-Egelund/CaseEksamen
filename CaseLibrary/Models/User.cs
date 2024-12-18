using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Entities
{
    public class User
    {

        


        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Dictionary<string, Booking> AssignedBookings{ get; set; }
        public Dictionary<string, BookableEvent> AssignedEvents{ get; set; }



        public User(string name, string email, string password, string phone, string address, string city, string zipCode)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            City = city;
            ZipCode = zipCode;
            AssignedBookings = new Dictionary<string, Booking>();
            AssignedEvents = new Dictionary<string, BookableEvent>();
        }




        public override string ToString()
        {
            if (AssignedBookings.Count > 0 || AssignedEvents.Count >0)
            {
                return $"--------------------------------------\n" +
                $"Name: {Name}\n" +
                $"Email: {Email}\n" +
                $"Phonenumber: {Phone}\n" +
                $"Adress: {Address}\n" +
                $"City: {City}\n" +
                $"Zipcode: {ZipCode}\n" +
                $"Bookings assigned to user: \n{string.Join("\n",AssignedBookings.Values.Select(booking => booking.BookingId))}\n" +
                $"Events assigned to user: \n{string.Join("\n", AssignedEvents.Values.Select(bookableEvent => bookableEvent.EventId))}\n";
            }
            else
            {

                return $"" +
                    $"Name: {Name}\n" +
                    $"Email: {Email}\n" +
                    $"Phonenumber: {Phone}\n" +
                    $"Adress: {Address}\n" +
                    $"City: {City}\n" +
                    $"Zipcode: {ZipCode}\n";
            }
        }

        public void AssignBookingToUser(Booking booking)
        {
            AssignedBookings.TryAdd(booking.BookingId, booking);
        }

        public void AssignUserToEvent(BookableEvent bookableEvent)
        {
            AssignedEvents.TryAdd(bookableEvent.EventId, bookableEvent);
            bookableEvent.AssignedMembers.TryAdd(Email, this);
        }



    }
}
