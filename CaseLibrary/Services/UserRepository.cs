using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Servicses
{
    public class UserRepository : IUserRepository
    {


        /// <summary>
        /// Makes a dcitionary to handle the users to be recieved from MockData.cs
        /// </summary>
        private Dictionary<string, User> _users;



        /// <summary>
        /// Recieves a list of Users through GetUsers() methodcall from MockData.cs
        /// </summary>
        public UserRepository()
        {
            _users = MockData.GetUsers();
        }


        /// <summary>
        /// This method adds a User to the user dictionary by taking Email as parameter for the key and User object for the value
        /// </summary>
        /// <param name="email">This Email is used as a key in the user list</param>
        /// <param name="user">This is the entire user object</param>
        public void AddUser(User user)
        {
            _users.TryAdd(user.Email, user);
        }


        /// <summary>
        /// If the given key recieved as argument for email parameter is found within the User dictionary, this method removes the corresponding Key,valuePair
        /// </summary>
        /// <param name="email">This Email is used as a key in the user list</param>
        public void DeleteUserByEmail(string email)
        {
            if (_users.Keys.Contains(email))
            {
                _users.Remove(email);
            }
        }


        /// <summary>
        /// Returns the User dictionary
        /// </summary>
        public Dictionary<string, User> GetAllUsers()
        {
            return _users;
        }


        /// <summary>
        /// This methods checks if given key exist in the dictionary. If true the method returns the User with the corresponding key given as argument for Email parameter. If key isn't found method will return null
        /// </summary>
        /// <param name="email">This Email is used as a key in the user </param>
        /// <returns>Returns the value of the given key or returns null</returns>
        public User GetUserByEmail(string email)
        {
            if(_users.ContainsKey(email))
            {
                return (_users[email]);
            }
            else return null;
        }



     
        public void UpdateUserByEmail(string email)
        {


            try
            {


                User currentUser = GetUserByEmail(email);


                Console.WriteLine($"You are editing this User: \n\n {currentUser}");

                Console.WriteLine("Do you want to edit the Name of this user?\n" +
                    "(Y)es or (N)o?");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the new User Name here: \n");
                    currentUser.Name = Console.ReadLine();
                }




                Console.WriteLine("Do you want to edit the password of this user?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the new User password here: \n");
                    currentUser.Password = Console.ReadLine();
                }




                Console.WriteLine("Do you want to edit the phonenumber of this user?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the new User phonenumber here: \n");
                    currentUser.Phone = Console.ReadLine();
                }


                Console.WriteLine("Do you want to edit the address of this user?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the new User address here: \n");
                    currentUser.Address = Console.ReadLine();
                }




                Console.WriteLine("Do you want to edit the city of this user?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the new User city here: \n");
                    currentUser.City = Console.ReadLine();
                }



                Console.WriteLine("Do you want to edit the zipcode of this user?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the new User zipcode here: \n");
                    currentUser.ZipCode = Console.ReadLine();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }









        }
    }
}
