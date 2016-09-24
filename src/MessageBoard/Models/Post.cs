using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MessageBoard.Models;

namespace MessageBoard.Models
{
    [Table("Posts")]
    public class Post
    {
        public Post()
        { 
        this.Comments = new HashSet<Comment>();
            }
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
