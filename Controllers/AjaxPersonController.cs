using LexiconMvc.Models;
using LexiconMvc.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                _personService.DeleteById(id);
            } 
            catch(KeyNotFoundException exception)
            {
                return NotFound(exception.Message);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Save(CreatePersonViewModel person)
        {
            Person createdPerson = new Person();

            if (ModelState.IsValid)
            {
                createdPerson = _personService.Save(person);


                if (createdPerson == null)
                {
                    return BadRequest();
                }
            }
            return CreatedAtAction(nameof(GetById), new { Id = createdPerson.Id }, createdPerson);
        }

        //[HttpGet]
        [HttpPost]
        public IActionResult GetById(int id)
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
