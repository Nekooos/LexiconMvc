using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models.Identity
{
    public class UserRolesViewModel
    {
        public String RoleId { get; set; }
        public String RoleName { get; set; }
        public bool isSelected { get; set; }
    }
}
