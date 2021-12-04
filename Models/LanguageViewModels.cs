using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class LanguageViewModels
    {
        public List<Language> Languages { get; set; }
        public Language Language { get; set; }

        public LanguageViewModels(List<Language> languages)
        {
            Languages = languages;
        }
    }
}
