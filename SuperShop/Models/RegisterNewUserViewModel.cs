using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
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
        [Display(Name = "Email")]
        public string Username { get; set; }


        [MaxLength(100, ErrorMessage = "The field {0} can only contain {1} characters!")]
        public string Address { get; set; }

        [MaxLength(20, ErrorMessage = "The field {0} can only contain {1} characters!")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "City")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a city!")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }

        [Display(Name = "Country")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a country!")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Password")]
        public string Password {  get; set; }

        [Required]
        [MinLength(4)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string Confirm {  get; set; }
    }
}
