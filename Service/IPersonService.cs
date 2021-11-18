using LexiconMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Service
{
    public interface IPersonService
    {
        List<PersonViewModel> GetAll();

        Person Save(CreatePersonViewModel createPersonViewModel);

        List<PersonViewModel> FilterByCityOrName(string filter);

        void DeleteByPhoneNumber(string phoneNumber);

        void DeleteById(long id);

        Person GetByPhoneNumber(String phoneNmber);

        PersonViewModel CreatePersonViewModel(Person person);

        Person GetById(long id);
    }
}
