using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }

        public String Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
