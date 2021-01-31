using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BlogSection : BaseEntity
    {
        public string BlogSectionTitle { get; set; }
        public string Description { get; set; }
        public IEnumerable<BlogPost> BlogPosts { get; set; }
    }
}
