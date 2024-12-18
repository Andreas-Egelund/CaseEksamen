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
            throw new NotImplementedException();
        }
    }
}
