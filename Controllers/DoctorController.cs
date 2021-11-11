using LexiconMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Controllers
{
    public class DoctorController : Controller
    {
        
        public IActionResult FeverCheck()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(FeverForm feverForm)
        {
            Boolean isValid = FeverFormValidation.isValidFeverValue(feverForm.FeverValue);
            String feverMessage = feverForm.FeverValue > 36 ? "You have a fever" : "You don't have a fever";
            ViewBag.FeverMessage = isValid ? feverMessage : "";
            return View();
        }
    }
}
