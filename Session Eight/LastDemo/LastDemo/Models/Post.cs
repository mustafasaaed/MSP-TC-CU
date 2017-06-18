using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public bool Pubished { get; set; }
        public DateTime PostedOn { get; set; }
    }
}