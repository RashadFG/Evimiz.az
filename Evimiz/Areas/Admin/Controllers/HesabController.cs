using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HesabController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HesabController(UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult AdminLogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AdminLogIn(LoginViewModelAdmin loginViewModelAdmin)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Şifrə və ya Email düzgün deyil");
                return View(loginViewModelAdmin);
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(loginViewModelAdmin.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu adlı istifadəçi yoxdur");
                return View(loginViewModelAdmin);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginViewModelAdmin.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifrə və ya Email düzgün deyil");
                return View(loginViewModelAdmin);
            }

            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public async  Task<IActionResult> AdminLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Dashboard");
        }

    }
}