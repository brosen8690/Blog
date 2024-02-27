using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dal.Models
{
    public class Post
    {
        public string Title { get; set; } = string.Empty;
        public string Html { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
    }
}
