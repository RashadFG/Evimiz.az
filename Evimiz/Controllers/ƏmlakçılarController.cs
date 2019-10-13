using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Controllers
{
    public class ƏmlakçılarController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ƏmlakçılarController(Db_Evimiz context,
                                    UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Profilim(string  id)
        {
            if (id == null) return View("Views/Evimiz/Error.cshtml");
            ApplicationUser offlineUser = await _userManager.FindByIdAsync(id);

            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.ApplicationUserId == offlineUser.Id),
                User = offlineUser
            };
            return View(model);
        }
    }
}