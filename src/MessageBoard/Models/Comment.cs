using MessageBoard.Models;
using MessageBoard.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageBoard.ViewModels
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Response { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
