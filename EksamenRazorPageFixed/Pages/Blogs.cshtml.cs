using CaseLibrary.Data;
using CaseLibrary.Models;
using CaseLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class BlogsModel : PageModel
    {
        public Dictionary<string, Blog> Blogs;

        public BlogsModel(BlogRepository BlogRepo)
        {
            Blogs = BlogRepo.GetAllBlogs();
        }
        public void OnGet()
        {
        }
    }
}
