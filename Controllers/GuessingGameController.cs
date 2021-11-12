using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LexiconMvc.Service;
using LexiconMvc.Models;

namespace LexiconMvc.Controllers
{
    public class GuessingGameController : Controller
    {
        private IGuessingGameService _guessingGameService;
        public GuessingGameController(IGuessingGameService guessingGameService)
        {
            _guessingGameService = guessingGameService;
        }
     
        public IActionResult GuessingGame()
        {
            _guessingGameService.SetSessionRandomNumber("Answer");
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(GuessingGameForm guessingGFameForm)
        {
            int answer = _guessingGameService.getSessionAnswer("Answer");

            ViewBag.Message = _guessingGameService.GuessNumber(guessingGFameForm.Guess, answer);

            return View();
        }

    }
}
