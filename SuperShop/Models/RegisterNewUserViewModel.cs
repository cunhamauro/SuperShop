using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName {  get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [MinLength(4)]
        public string Password {  get; set; }

        [Required]
        [MinLength(4)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string Confirm {  get; set; }
    }
}
