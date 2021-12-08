using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class ApplicationRole : IdentityRole
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String BirthDate { get; set; }

    }
}
