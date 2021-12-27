using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class PersonLanguage
    {
        public int PersonId { get; set; }
   
        public int LanguageId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }

        public Language Language { get; set; }

        public PersonLanguage(int personId, int languageId)
        {
            PersonId = personId;
            LanguageId = languageId;
        }

        public PersonLanguage()
        {

        }
    }
}
