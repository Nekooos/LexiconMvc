using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LexiconMvc.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ShowContactInformation()
        {
            ViewBag.Headline = "Contact information";
            ViewBag.Name = "Kristoffer Gustafsson";
            ViewBag.Address = "Imaginary Street 44B 123 45 Göteborg";
            ViewBag.PhoneNumber = "070 777 77 77";
            ViewBag.Email = "mail@mail.com";

            return View();
        }
    }
}
