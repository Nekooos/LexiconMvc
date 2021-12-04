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
    public class LanguagesController : Controller
    {
        private readonly LexiconMvcContext _context;

        public LanguagesController(LexiconMvcContext context)
        {
            _context = context;
        }

        // GET: Languages
        public IActionResult Index()
        {
            return View(new LanguageViewModels(_context.Language.ToList()));
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Name")] Language language)
        {
            if (ModelState.IsValid)
            {
                _context.Add(language);
                _context.SaveChanges();
                
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            var language = _context.Language
                .FirstOrDefault(language => language.Id == id);
            if (language == null)
            {
                return NotFound();
            }

            _context.Language.Remove(language);
            _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool LanguageExists(int id)
        {
            return _context.Language.Any(e => e.Id == id);
        }
    }
}
