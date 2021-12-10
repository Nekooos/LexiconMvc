using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LexiconMvc.Data;
using LexiconMvc.Models;
using Microsoft.AspNetCore.Authorization;

namespace LexiconMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CountriesController : Controller
    {
        private readonly LexiconMvcContext _context;

        public CountriesController(LexiconMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View( new CountriesViewModels(_context.Countries.ToList()
                .Select(country => CreateCountryViewModel(country))
                .ToList()));
        }

        public IActionResult Edit(int id)
        {

            Country country = _context.Countries
                .FirstOrDefault(country => country.Id == id);

            if (country == null)
            {
                return NotFound();
            }


            return View(country);
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public IActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(country).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = _context.Countries
                .FirstOrDefault(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

 
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Add(country);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        public IActionResult Delete(int id)
        {
            var country = _context.Countries
                .Include(country => country.Cities)
                .FirstOrDefault(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            try {
                _context.Countries.Remove(country);
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                ViewBag.ErrorMessage = "Delete persons connected to the country first";
            }
            catch(Exception exception)
            {
                ViewBag.ErrorMessage = exception.Message;
            }

            return RedirectToAction(nameof(Index));
        }

        private bool CountryExists(int id)
        {
            return _context.Countries.Any(e => e.Id == id);
        }

        private CountryViewModel CreateCountryViewModel(Country country) 
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            countryViewModel.CountryId = country.Id;
            countryViewModel.Name = country.Name;
            countryViewModel.Cities = country.Cities;
            return countryViewModel;
        }
    }
}
