using System.ComponentModel.DataAnnotations;

namespace Krammatik_Frontend.Models
{
    public class SignupModel
    {
        [Display(Name = "User Name")]
        [Required]
        [EmailAddress]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
