using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models.Identity
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(20)]
        public string BirthDate { get; set; }

        //[EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
