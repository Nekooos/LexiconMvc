using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class CityViewModel
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }

        public List<Person> Persons { get; set; }
    }
}
