﻿using LexiconMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Data
{
    public class PersonData: IPersonData
    {
        public List<Person> Persons { get; set; }

        public PersonData()
        {
            Persons = new List<Person>()
            {
                new Person("Kristoffer", "Göteborg", "070 111 11 11"),
                new Person("Rebecca", "Göteborg", "070 111 11 12"),
                new Person("Marvin", "Växjö", "070 111 11 13"),
                new Person("Sara", "Växjö", "070 111 11 14"),
                new Person("Marcus", "Malmö", "070 111 11 15"),
                new Person("Magnus", "Malmö", "070 111 11 16")
            };
        }

        public List<Person> GetAll()
        {
            return Persons;
        }

        public void Save(Person person)
        {
            Persons.Add(person);
        }

       
        public void DeleteByPhoneNumber(String phoneNumber)
        {
            var personToRemove = Persons.SingleOrDefault(person => person.PhoneNumber.Equals(phoneNumber));

            if (personToRemove != null)
                Persons.Remove(personToRemove);
        }

        public bool ExistsByPhoneNumber(String phoneNumber)
        {
           return Persons.Exists(person => person.PhoneNumber.Equals(phoneNumber));
        }
    }
}