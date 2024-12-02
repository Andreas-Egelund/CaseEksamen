using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Entities
{
    class User
    {

        private int _id;
        private static int _nextId;

        private string _name;
        private string _email;
        private string _password;
        private string _phone;
        private string _address;
        private string _city;
        private string _zipCode;

        public User(string name, string email, string password, string phone, string address, string city, string zipCode)
        {
            _name = name;
            _email = email;
            _password = password;
            _phone = phone;
            _address = address;
            _city = city;
            _zipCode = zipCode;
            _nextId++;
            _id = _nextId;


        }

        public void Login()
        {
            Console.WriteLine("User is logged in");
        }



        public void logout()
        {
            Console.WriteLine("gedhegeh");
        }

    }
}
