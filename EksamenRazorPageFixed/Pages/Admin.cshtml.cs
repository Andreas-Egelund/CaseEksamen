using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using CaseLibrary.Services;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class AdminModel : PageModel
    {
        public Dictionary<string, User> Users { get; set; }
        public Dictionary<string, Boat> Boats { get; set; }
        public Dictionary<string, Blog> Blogs { get; set; }
        public Dictionary<string, BookableEvent> BookableEvents { get; set; }
        public Dictionary<string, Booking> Bookings { get; set; }


        public AdminModel(UserRepository userRepo, BoatRepository boatRepo, BlogRepository blogRepo,EventRepository eventRepo, BookingRepository bookingRepo)
        {
            Users = userRepo.GetAllUsers();
            Boats = boatRepo.GetAllBoats();
            Blogs = blogRepo.GetAllBlogs();
            BookableEvents = eventRepo.GetAllEvents();
            Bookings = bookingRepo.GetAllBooking();
        }

        public void OnGet()
        {
        }


        public void OnPostAddUser(string name, string email, string password, string phone, string address, string city, string zipCode)
        {
            User newUser = new User( name,  email,  password,  phone,  address,  city,  zipCode);

            Users.TryAdd(newUser.Email,newUser);

        }

        public void OnPostAddRowBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance,string woodGrain)
        {
            RowBoat newRowboat = new RowBoat( boatNumber,  name,  model,  measure,  yearOfConstruction,  needsRepair,  lastRepair,  lastMaintenance,  woodGrain);

            Boats.TryAdd(newRowboat.BoatNumber, newRowboat);
            
        }

        public void OnPostAddSailBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance, string sailMaterial)
        {
            SailBoat newSailboat = new SailBoat(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance, sailMaterial);

            Boats.TryAdd(newSailboat.BoatNumber, newSailboat);

        }

        public void OnPostAddMotorBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance)
        {
            MotorBoat newMotorboat = new MotorBoat(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance, new JetDriveEngine("DI09 070M", 250, "ICFN", "2000"));

            Boats.TryAdd(newMotorboat.BoatNumber, newMotorboat);

        }

        public void OnPostUpdateUser(string EditedUserEmail)
        {

                Users[EditedUserEmail].Name = Request.Form[$"Users[{EditedUserEmail}].Name"];
                Users[EditedUserEmail].Email = Request.Form[$"Users[{EditedUserEmail}].Email"];
                Users[EditedUserEmail].Password = Request.Form[$"Users[{EditedUserEmail}].Password"];
                Users[EditedUserEmail].Phone = Request.Form[$"Users[{EditedUserEmail}].Phone"];
                Users[EditedUserEmail].Address = Request.Form[$"Users[{EditedUserEmail}].Address"];
                Users[EditedUserEmail].City = Request.Form[$"Users[{EditedUserEmail}].City"];
                Users[EditedUserEmail].ZipCode = Request.Form[$"Users[{EditedUserEmail}].ZipCode"];


        }



    }
}
