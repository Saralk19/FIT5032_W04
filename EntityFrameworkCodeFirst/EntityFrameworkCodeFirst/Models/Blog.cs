using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Models
{
    public class Blog
    {
        public int Blogid { get; set; }
        public string name { get; set; }
        public virtual List<Post> Posts { get; set; }

    }
}