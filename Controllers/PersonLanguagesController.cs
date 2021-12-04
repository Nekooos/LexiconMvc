﻿using System;
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
    public class PersonLanguagesController : Controller
    {
        private readonly LexiconMvcContext _context;

        public PersonLanguagesController(LexiconMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name");
            ViewData["PersonId"] = new SelectList(_context.Persons, "Id", "Name");
            return View(new PersonLanguageViewModels(
                    _context.PersonLanguage
                        .Include(p => p.Language)
                        .Include(p => p.Person).ToList()
                )); ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId, LanguageId")] PersonLanguage personLanguage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personLanguage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Name", personLanguage.LanguageId);
            ViewData["PersonId"] = new SelectList(_context.Persons, "Id", "Name", personLanguage.PersonId);
            return View(personLanguage);
        }

        public IActionResult Delete(int? id)
        {

            var personLanguage = _context.PersonLanguage
                .Include(p => p.Language)
                .Include(p => p.Person)
                .FirstOrDefault(m => m.PersonId == id);
            if (personLanguage == null)
            {
                return NotFound();
            }
            _context.PersonLanguage.Remove(personLanguage);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private bool PersonLanguageExists(int id)
        {
            return _context.PersonLanguage.Any(e => e.PersonId == id);
        }
    }
}
