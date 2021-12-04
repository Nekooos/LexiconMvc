using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class PersonLanguageViewModels
    {
        public List<PersonLanguage> PersonLanguages { get; set; }
        public PersonLanguage PersonLanguage { get; set; }


        public PersonLanguageViewModels(List<PersonLanguage> personLanguages)
        {
            PersonLanguages = personLanguages;
        }

        public PersonLanguageViewModels()
        {

        }
    }
}
