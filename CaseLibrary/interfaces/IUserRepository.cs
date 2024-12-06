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
        private List<User> users();

        public List<User> GetAllUsers();

        public User GetuserById(int id);

        public void AddUseer(User user);

        public void UpdateUSer(User user);

        public void deleteUser(int id); 


    }
}
