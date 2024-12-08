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
        private string Password { get; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Dictionary<string, Booking> AssignedBookings { get; set; }



        public User(string name, string email, string password, string phone, string address, string city, string zipCode)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Adress = address;
            City = city;
            ZipCode = zipCode;
        }

        public void Login()
        {
            Console.WriteLine("User is logged in");
        }



        public void logout()
        {
            Console.WriteLine("gedhegeh");
        }


        public override string ToString()
        {
            return $"" +
                $"Name: {Name}\n" +
                $"Email: {Email}\n" +
                $"Phonenumber: {Phone}\n" +
                $"Adress: {Adress}\n" +
                $"City: {City}\n" +
                $"Zipcode: {ZipCode}\n";

        }


    }
}
