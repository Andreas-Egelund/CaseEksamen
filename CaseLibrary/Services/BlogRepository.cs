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

        public void DeleteBlogByAuthor(string author)
        {
            if (_blogs.Keys.Contains(author))
            {
                _blogs.Remove(author);
            }
        }

        public Dictionary<string, Blog> GetAllBlogs()
        {
            return _blogs;
        }

        public Blog GetBlogByAuthor(string author)
        {

            if (_blogs.ContainsKey(author))
            {
                return (_blogs[author]);
            }
            else return null;
        }

        public void UpdateBlogByAuthor(string author)
        {
            throw new NotImplementedException();
        }
    }
}
