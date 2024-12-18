using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.Interfaces;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Services
{
    public class BlogRepository : IblogRepository
    {

        private Dictionary<string, Blog> _blogs;

        public BlogRepository()
        {
            _blogs = MockData.GetBlogs();

        }

        public void AddBlog(Blog blog)
        {
            _blogs.TryAdd(blog.BlogId, blog);
        }

        public void DeleteBlogByBlogId(string BlogId)
        {
            if (_blogs.Keys.Contains(BlogId))
            {
                _blogs.Remove(BlogId);
            }
        }

        public Dictionary<string, Blog> GetAllBlogs()
        {
            return _blogs;
        }

        public Blog GetBlogByBlogId(string BlogId)
        {
            
            if (_blogs.ContainsKey(BlogId))
            {
                return (_blogs[BlogId]);
            }
            else return null;
        }

        public void UpdateBlogByBlogId(string BlogId)
        {
            try
            {
                Blog currentBlog = GetBlogByBlogId(BlogId);


                Console.WriteLine($"You are editing this blog: \n\n {currentBlog}");

                Console.WriteLine("Do you want to edit the Blog title?\n" +
                    "(Y)es or (N)o?");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" ||answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new title here: \n");
                    currentBlog.BlogTitel = Console.ReadLine();
                    currentBlog.Date = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";   
                }

                 Console.WriteLine("Do you want to edit the Blogs content?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new Blog content here: \n");
                    currentBlog.BodyText = Console.ReadLine();
                    currentBlog.Date = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
