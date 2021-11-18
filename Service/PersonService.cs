﻿using System;
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

        public Person Save(CreatePersonViewModel createPersonViewModel)
        {
            if (_personData.ExistsByPhoneNumber(createPersonViewModel.PhoneNumber))
            {
                return null;
            }
            Person person = CreatePerson(createPersonViewModel);
            _personData.Save(person);
            return person;
          
        }

        public List<PersonViewModel> FilterByCityOrName(string searchWord)
        {
            var searchWordLowerCase = searchWord.ToLower();
            return _personData.GetAll()
                .Where(person => person.Name.ToLower().Equals(searchWordLowerCase) || person.City.ToLower().Equals(searchWordLowerCase))
                .Select(person => CreatePersonViewModel(person))
                .ToList();
        }

        public void DeleteByPhoneNumber(String phoneNumber)
        {
            Person person  = _personData.GetByPhoneNumber(phoneNumber);

            if (person != null)
                _personData.DeletePerson(person);
            else
            {
                throw new KeyNotFoundException("Person does not exist");
            }
        }

        public Person GetByPhoneNumber(String phoneNumber)
        {
            return _personData.GetByPhoneNumber(phoneNumber);
            
        }

        private Person CreatePerson(CreatePersonViewModel createPersonViewModel)
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
            personViewModel.Name = person.Name;
            personViewModel.City = person.City;
            personViewModel.PhoneNumber = person.PhoneNumber;
            return personViewModel;
        }
    }
}
