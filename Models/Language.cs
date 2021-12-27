using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class Language
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [JsonIgnore]
        public List<PersonLanguage> PersonLanguages { get; set; }

        public Language(int id, String name)
        {
            Id = id;
            Name = name;
        }

        public Language()
        {

        }
    }
}
