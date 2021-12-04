using System;
using System.Collections.Generic;
using System.Linq;
using LexiconMvc.Data;
using LexiconMvc.Models;

namespace LexiconMvc.Service
{
    public class PersonService : IPersonService
    {
        private readonly LexiconMvcContext _context;

        public PersonService(IPersonData personData, LexiconMvcContext context)
        {
            _context = context;
        }

        public List<PersonViewModel> GetAll()
        {   
            var persons = _context.Persons
                .Select(person => person)
                .ToList();
            return persons
                .Select(person => CreatePersonViewModel(person))
                .ToList();
        }

        public Person Save(CreatePersonViewModel createPersonViewModel)
        {

            Person person = CreatePerson(createPersonViewModel);

            _context.Persons.Add(person);
            _context.SaveChanges();

            return person;
        }

        public List<PersonViewModel> FilterByCityOrName(string searchWord)
        {
            var searchWordLowerCase = searchWord.ToLower();
            return _context.Persons.ToList()
                .Where(person => person.Name.ToLower().Equals(searchWordLowerCase) || person.City.Name.ToLower().Equals(searchWordLowerCase))
                .Select(person => CreatePersonViewModel(person))
                .ToList();
        }

        public void DeleteByPhoneNumber(String phoneNumber)
        {
            Person person  = _context.Persons.Find(phoneNumber);

            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Could not delete person with phone number: " + phoneNumber + phoneNumber);
            }
        }

        public void DeleteById(int id)
        {
            Person person = _context.Persons.Find(id);

            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Could not delete person with id: " + id);
            }
        }

        public Person GetByPhoneNumber(String phoneNumber)
        {
            return _context.Persons.Find(phoneNumber);
            
        }

        public Person CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            Person person = new Person();
            person.Name = createPersonViewModel.Name;
            person.City = createPersonViewModel.City;
            person.PhoneNumber = createPersonViewModel.PhoneNumber;
            return person;
        }

        public PersonViewModel CreatePersonViewModel(Person person)
        {
            PersonViewModel personViewModel = new PersonViewModel();
            personViewModel.Id = person.Id;
            personViewModel.Name = person.Name;
            if(person.City != null)
                personViewModel.City = person.City;
            personViewModel.PhoneNumber = person.PhoneNumber;
            return personViewModel;
        }

        public Person GetById(int id)
        {
            return _context.Persons.Find(id);
            
        }
    }
}
