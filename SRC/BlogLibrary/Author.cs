using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Author : BaseEntity
    {
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public IEnumerable<BlogPost> BlogPosts { get; set; }
    }
}
