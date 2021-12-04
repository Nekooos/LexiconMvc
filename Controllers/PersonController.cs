using LexiconMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LexiconMvc.Service;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using LexiconMvc.Data;
using System.Linq;

namespace LexiconMvc.Controllers
{
    public class PersonController : Controller
    {

        private readonly IPersonService _personService;
        private readonly LexiconMvcContext _context;
        public PersonController(IPersonService personService, LexiconMvcContext context)
        {
            _personService = personService;
            _context = context;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            List<PersonViewModel> personViewModelsList = _personService.GetAll();
            return View( new PeopleViewModel(personViewModelsList));
          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Name, PhoneNumber, CityId")] CreatePersonViewModel createPersonViewModel)
        {
            Person person = CreatePerson(createPersonViewModel);
            if (ModelState.IsValid)
            {
                _context.Add(person);
                _context.SaveChanges();
               
            }

            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name", person.CityId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Search(String SearchPhrase)
        {
            List<PersonViewModel> personViewModelsList;

            if(SearchPhrase != null)
            {
                personViewModelsList = _personService.FilterByCityOrName(SearchPhrase);
            }
            else
            {
                personViewModelsList = _personService.GetAll();
            }

            return View("Index", new PeopleViewModel(personViewModelsList));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var person = _context.Persons
                .FirstOrDefault(person => person.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(person);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private Person CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            Person person = new Person();
            person.Name = createPersonViewModel.Name;
            person.City = createPersonViewModel.City;
            person.CityId = createPersonViewModel.CityId;
            person.PhoneNumber = createPersonViewModel.PhoneNumber;
            return person;
        }
    }
}
