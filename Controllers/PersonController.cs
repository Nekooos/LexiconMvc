﻿using LexiconMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LexiconMvc.Data;
using LexiconMvc.Service;
using System.Data;

namespace LexiconMvc.Controllers
{
    public class PersonController : Controller
    {

        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
  
        }
        
        [HttpGet]
        public ActionResult PeopleIndex()
        {
            
            List<PersonViewModel> personViewModelsList = _personService.GetAll();
            return View( new PeopleViewModel(personViewModelsList));
          
        }

        [HttpPost]
        public ActionResult Save(CreatePersonViewModel createPersonViewModel)
        {
            if (ModelState.IsValid)
                try
                {
                    _personService.Save(createPersonViewModel);
                } 
                catch(DataException)
                {
                    ViewBag.ErrorMessage = "Could not save Person";
                }

            return RedirectToAction("PeopleIndex");
        }

        [HttpPost]
        public ActionResult Search(String SearchPhrase)
        {
            List<PersonViewModel> personViewModelsList;

            if(SearchPhrase != null)
            {
                personViewModelsList = _personService.FilterByCityOrName(SearchPhrase);
            }
            else
            {
                personViewModelsList = _personService.GetAll();
            }

            return View("PeopleIndex", new PeopleViewModel(personViewModelsList));
        }

        [HttpDelete]
        public ActionResult Delete(String phoneNumber)
        {
            try 
            {
                _personService.DeleteByPhoneNumber(phoneNumber);
            }
            catch(KeyNotFoundException exception)
            {
                ViewBag.ErrorMessage = exception.Message;
            }
            return View("PeopleIndex");
         }
    }
}
