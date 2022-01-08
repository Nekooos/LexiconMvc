using System.Linq;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using LexiconMvc.Data;
using LexiconMvc.Models;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LexiconMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : Controller
    {
        private readonly LexiconMvcContext _context;

        public ReactController(LexiconMvcContext context)
        {
            _context = context;
        } 

        // GET: api/<PeoplesReactController>
        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            var persons = await _context.Persons
                                    .Include(person => person.City)
                                    .Include(person => person.PersonLanguages)
                                    .ThenInclude(personLanguage => personLanguage.Language)
                                    .Include(person => person.City.Country)
                                    .Select(person => CreatePersonViewModel(person))
                                    .ToListAsync();
            return Ok(persons);
        }

        // GET api/<PeoplesReactController>/5
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            var person = _context.Persons
                .Include(person => person.City)
                .ThenInclude(city => city.Country)
                .Include(person => person.PersonLanguages)
                .ThenInclude(personLanguage => personLanguage.Language)
                .FirstOrDefault(person => person.Id == id);

            if(person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            return Ok(_context.Cities
                .Include(city => city.Country)
                .ToList());
        }

        [HttpGet("countries")]
        public IActionResult GetCountries()
        {
            return Ok(_context.Countries.ToList()); 
        }

        // POST api/<PeoplesReactController>
        [HttpPost("create")]
        public IActionResult Create(Person person)
        {

                _context.Add(person);
                _context.SaveChanges();
            

            return CreatedAtAction(nameof(Get), new { id = person.Id }, CreatePersonViewModel(person));
        }

        // PUT api/<PeoplesReactController>/5
        [HttpPut("put/{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<PeoplesReactController>/5
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
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

            return Ok();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        private static PersonViewModel CreatePersonViewModel(Person person)
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

        private Person CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            Person person = new Person();
            person.Name = createPersonViewModel.Name;
            person.CityId = createPersonViewModel.CityId;
            person.PhoneNumber = createPersonViewModel.PhoneNumber;
            return person;
        }
    }
}
