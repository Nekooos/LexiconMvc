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
        private IPersonService _personService;
        public AjaxPersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<PersonViewModel> personViewModelList = _personService.GetAll();
            return PartialView("AjaxPersonPartialView", personViewModelList);
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            try
            {
                _personService.DeleteById(id);
            } 
            catch(KeyNotFoundException exception)
            {
                return BadRequest(exception.Message);
            }

            return Ok();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CreatePersonViewModel person)
        {
            Person createdPerson = new Person();

            if (ModelState.IsValid)
            {
                createdPerson = _personService.Save(person);


                if (createdPerson == null)
                {
                    //Change to something better
                    return BadRequest();
                }
            }
            return CreatedAtAction(nameof(GetById), new { Id = createdPerson.Id }, createdPerson);
        }

        //[HttpGet]
        [HttpPost]
        public IActionResult GetById(long id)
        {
            Person person = _personService.GetById(id);

            if(person == null)
            {
                return NotFound("Could not find person  with id: " + id);
            }
            return PartialView("PersonDetails", _personService.CreatePersonViewModel(person));
        }

        public IActionResult AjaxPersonIndex()
        {
            return View();
        }
    }
}
