using LexiconMvc.Data;
using LexiconMvc.Models;
using LexiconMvc.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Controllers
{
    public class AjaxPersonController : Controller
    {
        private PersonService _personService;
        public AjaxPersonController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<PersonViewModel> personViewModelList = _personService.GetAll();
            return PartialView("PersonPartialView", personViewModelList);
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string phoneNumber)
        {
            try
            {
                _personService.DeleteByPhoneNumber(phoneNumber);
            } 
            catch(KeyNotFoundException exception)
            {
                return NotFound(exception.Message);
            }

            return Ok();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CreatePersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                var createdPerson = _personService.Save(person);

                if (createdPerson == null)
                {
                    //Change to something better
                    return BadRequest();
                }
            }
            return CreatedAtAction(nameof(GetByPhoneNumber), new { phoneNumber = person.PhoneNumber }, person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(String SearchPhrase)
        {
            List<PersonViewModel> personViewModelsList;

            if (SearchPhrase != null)
            {
                personViewModelsList = _personService.FilterByCityOrName(SearchPhrase);
            }
            else
            {
                personViewModelsList = _personService.GetAll();
            }
            return Ok(personViewModelsList);
        }

        [HttpGet]
        public IActionResult GetByPhoneNumber(String phoneNumber)
        {
            Person person = _personService.GetByPhoneNumber(phoneNumber);
            
            if(person == null)
            {
                return NotFound();
            }

            return Ok(_personService.CreatePersonViewModel(person));
        }
    }
}
