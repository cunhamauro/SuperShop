using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class ResetPasswordViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        [PasswordPropertyText]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword {  get; set; }

        [Required]
        public string Token {  get; set; }
    }
}
