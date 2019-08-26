using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SWSTechnologies1.Models
{
    public class ContactClientModel
    {
        [StringLength(100, MinimumLength =6, ErrorMessage ="Enter your full name.")]
        [Required(ErrorMessage ="Please enter your full name.")]
        public string Name { get; set; }
        [StringLength(10, MinimumLength =10, ErrorMessage ="Please enter a valid phone number.")]
        [Required(ErrorMessage ="Please enter your phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your Email Address.")]
        public string EmailAddress { get; set; }

        [Compare("EmailAddress", ErrorMessage ="Email address and confirm email address must match.")]
        public string ConfirmEmailAdress { get; set; }
        [StringLength(1000, MinimumLength =50, ErrorMessage ="Your message must be 50 characters or more")]
        [Required(ErrorMessage ="Please tell us how we can help you, or what questions you have about our services.")]
        public string Message { get; set; }
        
    }
}
