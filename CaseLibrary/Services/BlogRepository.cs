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
    public class BlogRepository : IblogRepository // We inherit from our IBlogRepository
    {

        private Dictionary<string, Blog> _blogs; // Here we create our dictionary

        public BlogRepository()
        {
            _blogs = MockData.GetBlogs();
        }


        /// <summary>
        /// This method takes the parameter blog of type Blog and adds it to our dictionary of Blogs where key is the BlogId and the blogobject is the value
        /// </summary>
        /// <param name="blog"></param>
        public void AddBlog(Blog blog)
        {
            _blogs.TryAdd(blog.BlogId, blog);
        }


        /// <summary>
        /// This method takes the paramenter author of type string, that search in the dictionary and if there's a key then it remove the entire <key, value> pair 
        /// </summary>
        /// <param name="author"></param>
        public void DeleteBlogByAuthor(string author)
        {
            if (_blogs.Keys.Contains(BlogId))
            {
                _blogs.Remove(BlogId);
            }
        }


        /// <summary>
        /// retuns Blogs dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Blog> GetAllBlogs()
        {
            return _blogs;
        }

        

        /// <summary>
        /// This method takes the parameter author of type string, checks if the given key is present in the dictionary, if true returns the corresponding <key,value> Pair
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public Blog GetBlogByAuthor(string author)
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
