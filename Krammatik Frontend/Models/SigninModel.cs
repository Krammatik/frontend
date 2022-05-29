using System.ComponentModel.DataAnnotations;

namespace Krammatik_Frontend.Models
{
    public class SignInModel
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
