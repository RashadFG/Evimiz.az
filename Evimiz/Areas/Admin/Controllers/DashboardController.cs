using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public DashboardController(UserManager<ApplicationUser> userManager,
                                   Db_Evimiz context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogIn", "Hesab");
            }

            var UserName = User.Identity.Name;

            if (UserName != null)
            {
                ApplicationUser user = await _userManager.FindByNameAsync(UserName);
                if (!await _userManager.IsInRoleAsync(user, "Admin"))
                {
                    return RedirectToAction("AdminLogIn", "Hesab");
                }
            }

            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Users = _context.Users.ToList()
            };

            return View(model);
        }

        public async Task<IActionResult> Advertisement()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList()
            };

            return View(model);
        }

        public IActionResult Istifadəçilər()
        {
            ViewModel model = new ViewModel()
            {
                Users = _context.Users.ToList()
            };

            return View(model);
        }

        public async Task<IActionResult> SaytHaqqında()
        {
            return View();
        }

        public async Task<IActionResult> Xəbərlər()
        {
            return View(_context.Newss.OrderByDescending(x => x.PublishDate));
        }

        public async Task<IActionResult> Gelenmektublar()
        {
            return View();
        }
    }
}
