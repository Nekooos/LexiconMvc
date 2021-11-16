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
        public void Save(Person person);

        public void DeleteByPhoneNumber(String phoneNumber);

        public bool ExistsByPhoneNumber(String phoneNumber);
    }
}
