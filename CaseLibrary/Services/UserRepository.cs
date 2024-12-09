using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
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
        public void AddUser(string email, User user)
        {
            _users.TryAdd(email, user);
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
        /// <param name="email">This Email is used as a key in the user list</param>
        /// <returns>Returns the value of the given key or returns null</returns>
        public User GetUserByEmail(string email)
        {
            if(_users.ContainsKey(email))
            {
                return (_users[email]);
            }
            else return null;
        }



        //TODO This Method is not working as intended. Will overwrite the User with given key to have a value of each element until last element in dictionary, resulting in always overwriting given key,valuePair with last element of dict.
        public void UpdateUserByEmail(string email)
        {
            foreach (var user in _users.Values ) 
            {
                _users[email] = user;
            }
        }
    }
}
