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



boatRepo.GetBoatBySailNumber("SB005").NeedsRepair = "The Front fell off";

//Console.WriteLine(userRepo.GetUserByEmail("alice.johnson@example.com"));

Console.WriteLine(boatRepo.GetBoatBySailNumber("SB005"));

boatRepo.GetBoatBySailNumber("SB005").Fixboat();


Console.WriteLine(boatRepo.GetBoatBySailNumber("SB005"));






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