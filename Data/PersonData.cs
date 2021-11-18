using LexiconMvc.Models;
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
                new Person(1, "Kristoffer", "Göteborg", "0701111111"),
                new Person(2, "Rebecca", "Göteborg", "0701111112"),
                new Person(3, "Marvin", "Växjö", "0701111113"),
                new Person(4, "Sara", "Växjö", "0701111114"),
                new Person(5, "Marcus", "Malmö", "0701111115"),
                new Person(6, "Magnus", "Malmö", "0701111116")
            };
        }

        public List<Person> GetAll()
        {
            return Persons;
        }

        public Person Save(Person person)
        {
            Persons.Add(person);
            return person;
        }

       
        public void DeletePerson(Person person)
        {
                Persons.Remove(person);
        }

        public bool ExistsByPhoneNumber(String phoneNumber)
        {
           return Persons.Exists(person => person.PhoneNumber.Equals(phoneNumber));
        }

        public Person GetById(long id)
        {
            return Persons.SingleOrDefault(person => person.Id.Equals(id));
        } 

        public Person GetByPhoneNumber(string phoneNumber)
        {
            return Persons.SingleOrDefault(person => person.PhoneNumber.Equals(phoneNumber));

        }

        public Person getById(long id)
        {
            return Persons.SingleOrDefault(person => person.Id == id);        
        } 
    }
}
