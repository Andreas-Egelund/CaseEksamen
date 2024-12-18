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
    public class UserRepository : IUserRepository // We inherit from our IUserRepository
    {

        private Dictionary<string, User> _users;

        public UserRepository()
        {
            _users = MockData.GetUsers(); // Here we create our dictionary
        }


        /// <summary>
        /// This method takes the parameter user of type User and adds it to our dictionary of Users where key is the email and the Usersobject is the value
        /// </summary>
        public void AddUser(string email, User user)
        {
            _users.TryAdd(email, user);
        }


        /// <summary>
        /// This method takes the paramenter email of type string, that search in the dictionary and if there's a key then it remove the entire <key, value> pair 
        /// </summary>
        /// <param name="email">
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
        /// This method takes the parameter email of type string, checks if the given key is present in the dictionary, if true returns the corresponding <key,value> Pair
        /// </summary>
        /// <param name="email">
        /// <returns></returns>
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
