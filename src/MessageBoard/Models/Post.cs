using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
