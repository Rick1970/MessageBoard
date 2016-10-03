using System.ComponentModel.DataAnnotations;

namespace MessageBoard.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
               
        [Required, DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required, DataType(DataType.Password), Compare("PassWord")]
        public string ConfirmPassword { get; set; }
    }
}
