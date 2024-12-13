using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class MembersModel : PageModel
    {
        private string _currentUserMail;
        public string CurrentUserMail { get => _currentUserMail; set => _currentUserMail = value; }



        public Dictionary<string, User> Members;


        public MembersModel(UserRepository userRepository)
        {
             Members = userRepository.GetAllUsers();
        }

        




        public void OnGet()
        {
        }

        public IActionResult OnPostGetCurrentUserByButton(string mail) 
        {

            TempData["CurrentUserMail"] = mail;
            return RedirectToPage("SubPage/UserInfoPage");

        }


    }
}
