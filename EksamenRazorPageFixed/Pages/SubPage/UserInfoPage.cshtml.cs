using CaseLibrary.Entities;
using CaseLibrary.Models;
using CaseLibrary.Services;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages.SubPage
{
    public class UserInfoPageModel : PageModel
    {
        public Dictionary<string, User> Members { get; set; }
        public Dictionary<string, Boat> Boats { get; set; }
        public Dictionary<string, BookableEvent> BookableEvents { get; set; }
        public string ErrorMessage { get; set; }




        public string CurrentUser { get; set; }


        public UserInfoPageModel(UserRepository userRepo, BoatRepository boatRepo, BookingRepository bookingRepo, EventRepository bookableEventsRepo)
        {
            Members = userRepo.GetAllUsers();
            Boats = boatRepo.GetAllBoats();
            BookableEvents = bookableEventsRepo.GetAllEvents();

        }

        public void OnGet()
        {

        }


        //SOLVED //How to access the current user and add only to their assignedbookingsdict   ///This was solved by using the Keep function on Tempdata to create persistence fo value
        public void OnPostCreateBooking(string boatNumber, string date, string duration, string location)
        {
            try
            {
                Booking newBooking = new Booking(Boats[boatNumber], date, duration, location);
                CurrentUser = TempData["CurrentUserMail"] as string;

                Members[CurrentUser].AssignedBookings.TryAdd(newBooking.BookingId, newBooking);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }



        public void OnPostRegisterForEvent2(string eventID)
        {

            try
            {
                CurrentUser = TempData["CurrentUserMail"] as string;
                Members[CurrentUser].AssignedEvents.TryAdd(BookableEvents[eventID].EventId, BookableEvents[eventID]);

                BookableEvents[eventID].AssignedMembers.TryAdd(Members[CurrentUser].Email, Members[CurrentUser]);

            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}