using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Response { get; set; }
        public string Author { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
