using CaseLibrary.Models;
using CaseLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages.BlogPage
{
    public class BlogInfoPageModel : PageModel
    {
        public Dictionary<string, Blog> Blogs { get; set; }
        public BlogInfoPageModel(BlogRepository blogRepo)
        {
            Blogs = blogRepo.GetAllBlogs();
        }
        public void OnGet()
        {
        }
    }
}
