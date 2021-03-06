﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageBoard.Models
{
    [Table("Posts")]
    public class Post
    {
        private int v;
        private string comments;

        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
                
       
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
