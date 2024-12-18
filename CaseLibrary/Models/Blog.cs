using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseLibrary.Models
{
    public class Blog
    {
        private static int _nextid = 0;

        public string BlogTitel { get; set; }
        public User Author { get; set; }
        public string BodyText { get; set; }
        public string Date { get; set; }
        public string BlogId {  get; set; }


        public Blog(string blogTitel, User author, string bodyText, string date)
        {
            BlogTitel = blogTitel;
            Author = author;
            BodyText = bodyText;
            Date = date;
            _nextid++;
            BlogId = $"BL00{_nextid}"; 
            
        }

        public override string ToString()
        {
            return $"---------------------------------------\n" +
                $"BlogTitel: {BlogTitel}\n" +
                $"Author:  {Author.Name}\n" +
                $"BodyText: \n \n{BodyText}\n \n" +
                $"Date: {Date}\n" +
                $"---------------------------------------\n";
        }
















    }
}
