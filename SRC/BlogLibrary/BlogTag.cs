using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BlogTag : BaseEntity
    {
        public string BlogTagName { get; set; }
        [ForeignKey("BlogPost")]
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
