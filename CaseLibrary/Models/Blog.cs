using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class Blog
    {


        public string BlogTitel { get; set; }
        public string Author { get; set; }
        public string BodyText { get; set; }
        public string Date { get; set; }



        public Blog(string blogTitel, string author, string bodyText, string date)
        {
            BlogTitel = blogTitel;
            Author = author;
            BodyText = bodyText;
            Date = date;
        }


















    }
}
