using LexiconMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Data
{
    public interface IPersonData
    {
        public List<Person> GetAll();
        public Person Save(Person person);

        public void DeletePerson(Person person);

        public bool ExistsByPhoneNumber(String phoneNumber);

        public Person GetByPhoneNumber(String phoneNumber);

        public Person GetById(long id);
    }
}
