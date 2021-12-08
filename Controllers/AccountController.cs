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
        private RoleManager<ApplicationRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            /*
            return View(

                (from user in _userManager.Users
                 select new
                 {
                     UserId = user.Id,
                     Username = user.UserName,
                     Email = user.Email,
                     RoleNames = (from userRole in user.UserRoles
                                  join role in context.Roles on userRole.RoleId
                                  equals role.Id
                                  select role.Name).ToList()
                 }).ToList());
            */

         
            return View(_userManager.Users
                .ToList()
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

                var result = await _userManager.CreateAsync(applicationUser, createUserViewModel.Password);

                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(applicationUser, "User");

                    await _signInManager.SignInAsync(applicationUser, isPersistent: false);
                    return RedirectToAction(nameof(Index));
                }

                
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }

        private ApplicationUser CreateApplicationUser(CreateUserViewModel createUser)
        {
            return new ApplicationUser
            {
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                Email = createUser.Email,
                UserName = createUser.Email,
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
