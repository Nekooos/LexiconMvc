using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LexiconMvc.Data;
using LexiconMvc.Models;

namespace LexiconMvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly LexiconMvcContext _context;

        public PeopleController(LexiconMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name");
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            return View(new PeopleViewModel
                            (
                                _context.Persons
                                    .Include(person => person.City)
                                    .Include(person => person.PersonLanguages)
                                    .ThenInclude(personLanguage => personLanguage.Language)
                                    .Include(person => person.City.Country)
                                    .ToList()
                                    .Select(person => CreatePersonViewModel(person))
                                    .ToList()
                            )
                        ); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Name, CityId, PhoneNumber")] CreatePersonViewModel createPersonViewModel)
        {
            Person person = CreatePerson(createPersonViewModel);
            if (ModelState.IsValid)
            {
                _context.Add(person);
                _context.SaveChanges();
            }
           
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int? id)
        {
            var person = _context.Persons
                .Include(person => person.City)
                .FirstOrDefault(person => person.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(person);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Persons.Any(person => person.Id == id);
        }

        public IActionResult Edit(int id)
        {

            Person person = _context.Persons
                .Include(person => person.City)
                .Include(person => person.PersonLanguages)
                .ThenInclude(personLanguage => personLanguage.Language)
                .FirstOrDefault(person => person.Id == id);

            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name");
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
     

            if (ModelState.IsValid)
            {
                _context.Entry(person).State = EntityState.Modified;
                _context.SaveChanges();
             
            }
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

        private PersonViewModel CreatePersonViewModel(Person person)
        {
            PersonViewModel personViewModel = new PersonViewModel();
            personViewModel.Id = person.Id;
            personViewModel.Name = person.Name;
            if (person.City != null)
                personViewModel.City = person.City;
            personViewModel.PhoneNumber = person.PhoneNumber;
            if (person.PersonLanguages != null)
                personViewModel.PersonLanguage = person.PersonLanguages;
            return personViewModel;
        }
    }
}
