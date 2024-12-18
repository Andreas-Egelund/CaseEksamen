using CaseLibrary.Entities;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Interfaces
{
    public interface IblogRepository
    {
        public void AddBlog(Blog blog);

        Dictionary<string, Blog> GetAllBlogs();

        Blog GetBlogByBlogId(string blogId);

        void UpdateBlogByBlogId(string blogId);

        void DeleteBlogByBlogId(string blogId);
    }
}
