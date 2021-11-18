using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class PersonViewModel
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String PhoneNumber { get; set; }

        public PersonViewModel()
        {

        }
    }
}
