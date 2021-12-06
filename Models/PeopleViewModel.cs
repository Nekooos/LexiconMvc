using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class PeopleViewModel
    {
        public List<PersonViewModel> Persons { get; set; }
        public String SearchPhrase { get; set; }
        public CreatePersonViewModel CreatePersonViewModel { get; set; }

        public Person Person { get; set; }

        public PeopleViewModel(List<PersonViewModel> persons, String searchPhrase, CreatePersonViewModel createPersonViewModel)
        {
            Persons = persons;
            SearchPhrase = searchPhrase;
            CreatePersonViewModel = createPersonViewModel;
        }

        public PeopleViewModel(List<PersonViewModel> persons)
        {
            Persons = persons;
        }

        public PeopleViewModel()
        {

        }
    }
}
