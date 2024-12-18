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
BlogRepository blogRepo = new BlogRepository();
EventRepository eventRepo = new EventRepository();


userRepo.GetUserByEmail("ethan.hunt@example.com").AssignUserToEvent(eventRepo.GetEventById("BE-Id-101"));



Console.WriteLine(userRepo.GetUserByEmail("ethan.hunt@example.com"));


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine(eventRepo.GetEventById("BE-Id-101")); 







/*

foreach(Booking booking in bookingRepo.GetAllBooking().Values)
{
    Console.WriteLine(booking);
}



Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

Booking bookingtest = new Booking(boatRepo.GetBoatBySailNumber("RB004"),DateTime.Now.ToString(),"99hours","præstø");

bookingRepo.AddBooking(bookingtest);


foreach (Booking booking in bookingRepo.GetAllBooking().Values)
{
    Console.WriteLine(booking);
}

*/


/*
userRepo.GetUserByEmail("alice.johnson@example.com").AssignBookingToUser(bookingRepo.GetBookingById("BK003"));
userRepo.GetUserByEmail("alice.johnson@example.com").AssignBookingToUser(bookingRepo.GetBookingById("BK001"));
Console.WriteLine(userRepo.GetUserByEmail("alice.johnson@example.com"));

*/



//Console.WriteLine("-------------------All Users From MockData-------------------");

//foreach(User user in userRepo.GetAllUsers().Values)
//{
//    Console.WriteLine(user);
//    Console.WriteLine();

//}


//Console.WriteLine("-------------------All Boats From MockData-------------------");

//foreach(Boat boat in boatRepo.GetAllBoats().Values)
//{
//    Console.WriteLine(boat);
//    Console.WriteLine();
//}


//Console.WriteLine("---------------------------------------------------------");