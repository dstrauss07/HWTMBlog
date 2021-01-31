using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BlogPost : BaseEntity
    {
        public string BlogPostTitle { get; set; }
        public string BlogText { get; set; }
        public IEnumerable<BlogTag> BlogTags { get; set; }

        [ForeignKey("BlogSection")]
        public int BlogSectionId { get; set; }
        public BlogSection BlogSection { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
