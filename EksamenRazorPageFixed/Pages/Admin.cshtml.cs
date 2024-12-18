using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using CaseLibrary.Models.EngineTypes;
using CaseLibrary.Services;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class AdminModel : PageModel
    {

        public string MyErrorMessage { get; set; }
        public Dictionary<string, User> Users { get; set; }
        public Dictionary<string, Boat> Boats { get; set; }
        public Dictionary<string, Blog> Blogs { get; set; }
        public Dictionary<string, BookableEvent> BookableEvents { get; set; }
        public Dictionary<string, Booking> Bookings { get; set; }


        public AdminModel(UserRepository userRepo, BoatRepository boatRepo, BlogRepository blogRepo,EventRepository eventRepo, BookingRepository bookingRepo) // here we take the repos to get our data
        {
            // We take our new dictionarys, then we transfer the data from repos to the new dictionary
            Users = userRepo.GetAllUsers();  
            Boats = boatRepo.GetAllBoats();  
            Blogs = blogRepo.GetAllBlogs();
            BookableEvents = eventRepo.GetAllEvents();
            Bookings = bookingRepo.GetAllBooking();
        }

        public void OnGet()
        {
        }



        /// <summary>
        /// This method takes the parameters of User constructor of type string and adds it to our dictionary of Users where key is the Email and the userobject is the value
        /// </summary>
        public void OnPostAddUser(string name, string email, string password, string phone, string address, string city, string zipCode)
        {

            try
            {
                User newUser = new User(name, email, password, phone, address, city, zipCode);

                Users.TryAdd(newUser.Email, newUser);
            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;
            }
        }




        public void OnPostAddRowBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance,string woodGrain)
        {
            try
            {
                RowBoat newRowboat = new RowBoat(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance, woodGrain);

                Boats.TryAdd(newRowboat.BoatNumber, newRowboat);
            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;
            }   
        }

        public void OnPostAddSailBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance, string sailMaterial)
        {
            try
            {
                SailBoat newSailboat = new SailBoat(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance, sailMaterial);

                Boats.TryAdd(newSailboat.BoatNumber, newSailboat);
            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;    
            }
        }


        /// <summary>
        /// This Method recieves arguments to the parameters of the motorboat constructor from the associated form and makes a new MotorBoat obj with these arguments
        /// </summary>
        public void OnPostAddMotorBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance, string engineType)
        {
            IEngine engine = new PropellerEngine("Propeller", 250, "ICFN", "2000");

            try
            {

                switch (engineType)
                {
                    case "PropellerEngine":
                        engine = new PropellerEngine("Propeller", 250, "ICFN", "2000");

                        
                        break;

                    case "JetEngineDrive":
                        engine = new PropellerEngine("JetDrive", 250, "ICFN", "2005");
                        break;

                    case "ElectricEngine":
                        engine = new PropellerEngine("Propeller", 250, "ICFN", "2000");
                        break;

                    default:
                        break;
                }

                MotorBoat MotorboatPropel = new MotorBoat(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance, engine);
                Boats.TryAdd(MotorboatPropel.BoatNumber, MotorboatPropel);
            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;
            }

        }








        /// <summary>
        /// This method takes parameter EditedUserEmail of type string that receives the email of the user currently being edited as argument.
        /// </summary>
        /// <param name="EditedUserEmail"></param>
        public void OnPostUpdateUser(string EditedUserEmail)
        {
           User user = Users[EditedUserEmail];   // saves the user currently being edit as var user  

            try
            {
                user.Name = Request.Form[$"Users[{EditedUserEmail}].Name"];    //Here we use Request.Form to get the value from the form with corresponding name.
                                                                               //For Example:  name="Users[@user.Email].Name"  Will be given the value of whatever the Admin types into the form.
                                                                               //In this case we then assign this value to the users property "Name"
                                                                               //@user.Email will have the same value as EditedUserEmail

                user.Email = Request.Form[$"Users[{EditedUserEmail}].Email"];
                user.Password = Request.Form[$"Users[{EditedUserEmail}].Password"];
                user.Phone = Request.Form[$"Users[{EditedUserEmail}].Phone"];
                user.Address = Request.Form[$"Users[{EditedUserEmail}].Address"];
                user.City = Request.Form[$"Users[{EditedUserEmail}].City"];
                user.ZipCode = Request.Form[$"Users[{EditedUserEmail}].ZipCode"];
            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;
            }

        }


        /// <summary>
        /// This method takes the paramenter EditedUserEmail of type string, that search in the dictionary and if there's a key then it remove the entire <key, value> pair
        /// </summary>
        /// <param name="EditedUserEmail"></param>
        public void OnPostRemoveUser(string EditedUserEmail)
        {
            try
            {
                foreach (var bookableEvents in Users[EditedUserEmail].AssignedEvents.Values)
                {
                    bookableEvents.AssignedMembers.Remove(EditedUserEmail);
                }

                Users.Remove(EditedUserEmail);
                
            }
            catch(Exception ex)
            {
                MyErrorMessage = ex.Message;
            }

        }



        public void OnPostUpdateBoat(string EditedBoatNumber)
        {
            try
            {
                Boats[EditedBoatNumber].Name = Request.Form[$"Boats[{EditedBoatNumber}].Name"];
                Boats[EditedBoatNumber].Model = Request.Form[$"Boats[{EditedBoatNumber}].Model"];
                Boats[EditedBoatNumber].Measurements = Request.Form[$"Boats[{EditedBoatNumber}].Measurements"];

                int.TryParse(Request.Form[$"Boats[{EditedBoatNumber}].YearOfConstruction"], out int year);  //Values from form will always be string by default.
                                                                                                            //Here we try to parse what the user has written in the form, to get the interger value and assign it to the property "YearOfConstruction".
                                                                                                            //If we cannot parse this the value will be set to int 0
                Boats[EditedBoatNumber].YearOfConstruction = year;


                Boats[EditedBoatNumber].NeedsRepair = Request.Form[$"Boats[{EditedBoatNumber}].NeedsRepair"];
                Boats[EditedBoatNumber].LastRepair = Request.Form[$"Boats[{EditedBoatNumber}].LastRepair"];
                Boats[EditedBoatNumber].LastMaintenance = Request.Form[$"Boats[{EditedBoatNumber}].LastMaintenance"];
            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;
            }

        }

        public void OnPostRemoveBoat(string EditedBoatNumber)
        {
            try
            {
                Boats.Remove(EditedBoatNumber);
            }
            catch (Exception ex)
            {
                MyErrorMessage = ex.Message;
            }

        }



        public void OnPostUpdateEvent(string EditedEventId)
        {
            try
            {
                BookableEvents[EditedEventId].EventName = Request.Form[$"BookableEvents[{EditedEventId}].EventName"];
                BookableEvents[EditedEventId].Date = Request.Form[$"BookableEvents[{EditedEventId}].Date"];
                BookableEvents[EditedEventId].Duration = Request.Form[$"BookableEvents[{EditedEventId}].Duration"];

            }
            catch (Exception ex)
            {

                MyErrorMessage = ex.Message;
            }

        }

        public void OnPostRemoveEvent(string EditedEventId)
        {
            try
            {
                foreach (var user in BookableEvents[EditedEventId].AssignedMembers.Values)
                {
                    user.AssignedEvents.Remove(EditedEventId);
                }

                BookableEvents.Remove(EditedEventId);
            }
            catch (Exception ex)
            {
                MyErrorMessage = ex.Message;
            }

        }


        public void OnPostAddEvent(string eventName, string date, string duration)
        {
            try
            {
                BookableEvent newEvent = new BookableEvent(eventName, date, duration);
                BookableEvents.TryAdd(newEvent.EventId,newEvent);
            }
            catch (Exception ex)
            {
                MyErrorMessage = ex.Message;
            }
        }



       /// <summary>
       /// This method takes you to a new page 
       /// </summary>
       /// <param name="Blogid"></param>
       /// <returns></returns>
        public IActionResult OnPostCreatingBlog()
        {
            return RedirectToPage("BlogPage/CreatingBlogs");
        }









    }
}
