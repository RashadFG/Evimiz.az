using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Controllers
{
    public class EvimizController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<İstifadəçi> _userManager;

        public EvimizController(Db_Evimiz context,
                              RoleManager<IdentityRole> roleManager,
                              IHostingEnvironment env,
                              UserManager<İstifadəçi> userManager
                              )
        {
            _context = context;
            _roleManager = roleManager;
            _env = env;
            _userManager = userManager;
        }

        public async Task<IActionResult> AnaSəhifə()
        {
            ViewBag.Home = "Home";

            #region CreateRole:)
            //if (!await _roleManager.RoleExistsAsync("Admin"))
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("Admin"));
            //}

            //if (!await _roleManager.RoleExistsAsync("Moderator"))
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("Moderator"));
            //}

            //if (!await _roleManager.RoleExistsAsync("Istifadəçi"))
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("Istifadəçi"));
            //}

            //if (!await _roleManager.RoleExistsAsync("Əmlakçı"))
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("Əmlakçı"));
            //}
            #endregion

            return View();

        }

        [ActionName("Xəbərlər")]
        public IActionResult News()
        {
            return View(_context.Newss.ToList());
        }

        [ActionName("Əmlakçılar")]
        public IActionResult Agents()
        {
            return View(_context.Users.Where(x => x.İsAgent == true));
        }

        [ActionName("Sifarişlər")]
        public IActionResult Orders()
        {
            return View();
        }

        [ActionName("Profilim")]
        public IActionResult MyProfile()
        {
            return View();
        }

        [ActionName("Haqqımızda")]
        public IActionResult About()
        {
            return View();
        }

        [ActionName("Elanlar")]
        public IActionResult Advertisement()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}