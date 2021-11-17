using System.Collections.Generic;
using System.Linq;
using LexiconMvc.Data;
using LexiconMvc.Models;

namespace LexiconMvc.Service
{
    public class PersonService : IPersonService
    {
        private IPersonData _personData;

        public PersonService(IPersonData personData)
        {
            _personData = personData;
        }

        public List<PersonViewModel> GetAll()
        {
            return _personData.GetAll()
                .Select(person => CreatePersonViewModel(person))
                .ToList();
        }

        public void Save(CreatePersonViewModel createPersonViewModel)
        {
            Person person = CreatePerson(createPersonViewModel);
            _personData.Save(person);
        }

        private Person CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            Person person = new Person();
            person.Name = createPersonViewModel.Name;
            person.City = createPersonViewModel.City;
            person.PhoneNumber = createPersonViewModel.PhoneNumber;
            return person;
        }

        private PersonViewModel CreatePersonViewModel(Person person) 
        {
            PersonViewModel personViewModel = new PersonViewModel();
            personViewModel.Name = person.Name;
            personViewModel.City = person.City;
            personViewModel.PhoneNumber = person.PhoneNumber;
            return personViewModel;
        }

        public List<PersonViewModel> FilterByCityOrName(string searchWord)
        {
            var searchWordLowerCase = searchWord.ToLower();
            return _personData.GetAll()
                .Where(person => person.Name.ToLower().Equals(searchWordLowerCase) || person.City.ToLower().Equals(searchWordLowerCase))
                .Select(person => CreatePersonViewModel(person))
                .ToList();
        }

        public void DeleteByPhoneNumber(string phoneNumber)
        {
            var person  = _personData.GetByPhoneNumber(phoneNumber);

            if (person != null)
                _personData.DeletePerson(person);
            else
            {
                throw new KeyNotFoundException("Person does not exist");
            }
        }
    }
}
