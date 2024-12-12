using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class MembersModel : PageModel
    { 
        public Dictionary<string, User> Members;
        public MembersModel(UserRepository userRepository)
        {
             Members = userRepository.GetAllUsers();
        }

        public void OnGet()
        {
        }
    }
}
