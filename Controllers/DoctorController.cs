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
        // Post
        public IActionResult FeverCheck(Fever fever)
        {

            return View();
        }
    }
}
