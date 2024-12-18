using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.interfaces
{
    public interface IUserRepository
    {

        void AddUser(User user);

        Dictionary<string,User> GetAllUsers();

        User GetUserByEmail(string email);

        void UpdateUserByEmail(string email);

        void DeleteUserByEmail(string email); 

    }
}
