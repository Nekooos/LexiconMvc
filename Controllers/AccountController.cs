using LexiconMvc.Models;
using LexiconMvc.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;


        }

        public IActionResult Index()
        {

            List<ApplicationUser> users = _userManager.Users.ToList();
            return View(
                _userManager.Users.ToList()
                .Select(user => createUserViewModel(user))
                .ToList());
        }

        public IActionResult Register()
        {
       
            return View(new CreateUserViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserViewModel createUserViewModel)
        {


            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = CreateApplicationUser(createUserViewModel);

                var result = await _userManager.CreateAsync(applicationUser, applicationUser.Password);

                if(result.Succeeded)
                {
                    await _signInManager.SignInAsync(applicationUser, isPersistent: false);
                    return RedirectToAction("Index");
                }

                
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        private ApplicationUser CreateApplicationUser(CreateUserViewModel createUser)
        {
            return new ApplicationUser
            {
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                Password = createUser.Password,
                Email = createUser.Email,
                BirthDate = createUser.BirthDate,
            };
        }

        private ApplicationUserViewModel createUserViewModel(ApplicationUser applicationUser)
        {
            return new ApplicationUserViewModel
            {
                FirstName = applicationUser.FirstName,
                LastName = applicationUser.LastName,
                Email = applicationUser.Email,
                BirthDate = applicationUser.BirthDate,
            };
        }
    }
}
