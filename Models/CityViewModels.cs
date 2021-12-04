using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LexiconMvc.Models
{
    public class CityViewModels
    {
        public List<CityViewModel> Cities { get; set; }
        public City City { get; set; }
        public SelectList Countries { get; set; }

        public CityViewModels(List<CityViewModel> cities)
        {
            Cities = cities;
        }
    }
}
