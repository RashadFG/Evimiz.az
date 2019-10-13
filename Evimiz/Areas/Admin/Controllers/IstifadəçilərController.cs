using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IstifadəçilərController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public IstifadəçilərController(Db_Evimiz context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Haqqinda(string id)
        {
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
