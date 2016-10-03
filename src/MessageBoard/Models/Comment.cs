using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageBoard.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Response { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
