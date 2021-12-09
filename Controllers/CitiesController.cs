using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LexiconMvc.Data;
using LexiconMvc.Models;

namespace LexiconMvc.Controllers
{
    public class CitiesController : Controller
    {
        private readonly LexiconMvcContext _context;

        public CitiesController(LexiconMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
            return View(
                    new CityViewModels(
                        _context.Cities
                        .Include(city => city.Country)
                        .ToList()
                        .Select(city => CreateCityViewModel(city))
                        .ToList()
                    )
                );
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Name, CountryId")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Add(city);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name", city.CountryId);
            return View(CreateCityViewModel(city));
        }


        public IActionResult Delete(int id)
        {
            var city = _context.Cities
                .Include(city => city.Country)
                .Include(city => city.Persons)
                .FirstOrDefault(city => city.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            _context.SaveChanges();



            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {

            City city = _context.Cities
                .FirstOrDefault(city => city.Id == id);

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        [HttpPost]
        public IActionResult Edit(City city)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(city).State = EntityState.Modified;
                _context.SaveChanges();

            }
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(city => city.Id == id);
        }

        private CityViewModel CreateCityViewModel(City city)
        {
            CityViewModel cityViewModel =  new CityViewModel();
            cityViewModel.Id = city.Id;
            cityViewModel.Name = city.Name;
            cityViewModel.Country = city.Country;
            cityViewModel.CountryId = city.CountryId ?? default(int);
            return cityViewModel;
        }
    }
}
