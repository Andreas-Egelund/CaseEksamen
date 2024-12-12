using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class BoatsModel : PageModel
    {

        public Dictionary<string, Boat> Boats { get; set; }


        public BoatsModel(BoatRepository boatRepo)
        {
            Boats = boatRepo.GetAllBoats();

            
        }


        public void OnGet()
        {

        }
    }
}
