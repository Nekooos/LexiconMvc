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

        void Save(CreatePersonViewModel createPersonViewModel);

        List<PersonViewModel> FilterByCityOrName(string filter);

        void DeleteByPhoneNumber(string phoneNumber);


    }
}
