using LexiconMvc.Models;
using LexiconMvc.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<ApplicationRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users
                .ToList()
                .Select(user => createUserViewModel(user))
                .ToList());
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
       
            return View(new CreateUserViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(CreateUserViewModel createUserViewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = CreateApplicationUser(createUserViewModel);

                var result = await _userManager.CreateAsync(applicationUser, createUserViewModel.Password);

                if(result.Succeeded)
                {
                    ApplicationRole applicationRole = await _roleManager.FindByNameAsync("User");
                    await _userManager.AddToRoleAsync(applicationUser, applicationRole.Name);

                    await _signInManager.SignInAsync(applicationUser, isPersistent: false);
                    return RedirectToAction("Index", "People");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
     
            return View(new UserLoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByEmailAsync(userLoginViewModel.Email);

                if (await _userManager.CheckPasswordAsync(user, userLoginViewModel.Password) == false)
                {
                    ModelState.AddModelError("message", "Invalid credentials");
                    return View(userLoginViewModel);
                }

                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.Email, userLoginViewModel.Password, userLoginViewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "People");
                }
                else
                {
                    ModelState.AddModelError("message", "Username or password is inconrrect");
                    return View(userLoginViewModel);
                }
            }
            return View(userLoginViewModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Login));
        }


        public async Task<IActionResult> EditUserRoles(String userId)
        {
            ViewBag.userId = userId;

            ApplicationUser user = await _userManager.FindByIdAsync(userId);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with Id: {userId} could not be found";
            }

            List<UserRolesViewModel> userRolesViewModelsList = new List<UserRolesViewModel>();
        
            foreach (var role in _roleManager.Roles.ToList())
            {
                UserRolesViewModel userRolesViewModel = new UserRolesViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                };
                userRolesViewModel.isSelected = await _userManager.IsInRoleAsync(user, role.Name);
       
                userRolesViewModelsList.Add(userRolesViewModel);
            }
            return View(userRolesViewModelsList);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserRoles(List<UserRolesViewModel> model, String userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            result = await _userManager.AddToRolesAsync(user, model
                .Where(role => role.isSelected)
                .Select(role => role.RoleName));

            return RedirectToAction(nameof(Index));
        }



        private ApplicationUser CreateApplicationUser(CreateUserViewModel createUser)
        {
            return new ApplicationUser
            {
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                Email = createUser.Email,
                UserName = createUser.Email,
                BirthDate = createUser.BirthDate
            };
        }

        private ApplicationUserViewModel createUserViewModel(ApplicationUser applicationUser)
        {
            return new ApplicationUserViewModel
            {
                Id = applicationUser.Id,
                FirstName = applicationUser.FirstName,
                LastName = applicationUser.LastName,
                Email = applicationUser.Email,
                BirthDate = applicationUser.BirthDate,
                Roles = String.Join(", ", _userManager.GetRolesAsync(applicationUser).Result.ToArray())
            };
        }
    }
}
