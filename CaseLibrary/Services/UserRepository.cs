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

        private Dictionary<string, User> _users;


        public UserRepository()
        {
            _users = MockData.GetUsers();
        }



        public void AddUser(string email, User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
