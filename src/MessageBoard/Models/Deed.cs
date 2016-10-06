using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageBoard.Models
{
    [Table("Deeds")]
          
        public class Deed
        {
            [Key]
            public int DeedId { get; set; }
            [Required]
            public string Text { get; set; }
 
        }
    }

