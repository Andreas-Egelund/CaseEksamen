using CaseLibrary.Data;
using CaseLibrary.Models;
using CaseLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace EksamenRazorPageFixed.Pages
{
    public class BookableEventsModel : PageModel
    {
        public Dictionary<string, BookableEvent> BookableEvents { get; set; }


        public BookableEventsModel(EventRepository EventRepo)
        {
            BookableEvents = EventRepo.GetAllEvents();
        }
        public void OnGet()
        {
        }
    }
}
