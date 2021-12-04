using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class CountriesViewModels
    {
        public List<CountryViewModel> Countries { get; set; }
        public Country Country { get; set; } 

        public CountriesViewModels(List<CountryViewModel> countries)
        {
            Countries = countries;
        }
    }
}
