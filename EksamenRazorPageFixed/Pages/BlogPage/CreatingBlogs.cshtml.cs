using CaseLibrary.Entities;
using CaseLibrary.Models;
using CaseLibrary.Services;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages.BlogPage
{
    public class CreatingBlogsModel : PageModel
    {
        public Dictionary<string, Blog> Blogs { get; set; }
        public Dictionary<string, User> Members { get; set; }
        public string ErrorMessage { get; set; }    

        public CreatingBlogsModel(BlogRepository blogRepo, UserRepository userRepo)
        {
            Blogs = blogRepo.GetAllBlogs();
            Members = userRepo.GetAllUsers();
        }
        public void OnGet()
        {
        }
        public void OnPostAddBlog(string Title, string authorMail, string Bodytext, string Date)
        {
            try
            {
                Blog TheNewBlog = new Blog(Title, Members[authorMail], Bodytext, Date);
                Blogs.TryAdd(TheNewBlog.BlogId, TheNewBlog);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}