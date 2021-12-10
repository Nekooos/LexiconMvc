using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public override String UserName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String BirthDate { get; set; }

        //public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
