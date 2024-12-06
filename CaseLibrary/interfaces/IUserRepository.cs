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
        List<User> users();

        List<User> GetAllUsers();

        User GetuserById(int id);

        void AddUseer(User user);

        void UpdateUSer(User user);

        void deleteUser(int id); 


    }
}
