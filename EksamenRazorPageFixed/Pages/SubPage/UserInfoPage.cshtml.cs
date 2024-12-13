using CaseLibrary.Entities;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages.SubPage
{
    public class UserInfoPageModel : PageModel
    {
        public Dictionary<string, User> Members { get; set; }
        public Dictionary<string, Boat> Boats { get; set; }



        public string CurrentUser { get; set; }


        public UserInfoPageModel(UserRepository userRepo)
        {
            Members = userRepo.GetAllUsers();
             

        }

        public void OnGet()
        {

        }
    }
}
