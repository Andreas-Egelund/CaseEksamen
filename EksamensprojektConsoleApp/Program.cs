// See https://aka.ms/new-console-template for more information

using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using CaseLibrary.Services;
using CaseLibrary.Servicses;


BoatRepository boatRepo = new BoatRepository();
UserRepository userRepo = new UserRepository();
BookingRepository bookingRepo = new BookingRepository();




Console.WriteLine("-------------------All Users From MockData-------------------");

foreach(User user in userRepo.GetAllUsers().Values)
{
    Console.WriteLine(user);
    Console.WriteLine();

}


Console.WriteLine("-------------------All Boats From MockData-------------------");

foreach(Boat boat in boatRepo.GetAllBoats().Values)
{
    Console.WriteLine(boat);
    Console.WriteLine();
}


Console.WriteLine("---------------------------------------------------------");