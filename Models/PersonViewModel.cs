using System;
using System.Collections.Generic;

namespace LexiconMvc.Models
{
    public class PersonViewModel
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public City City { get; set; }
        public String PhoneNumber { get; set; }

        public List<PersonLanguage> PersonLanguage { get; set; }
        public PersonViewModel()
        {

        }
    }
}
