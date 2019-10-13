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
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<ApplicationUser> _userManager;

        public EvimizController(Db_Evimiz context,
                              RoleManager<IdentityRole> roleManager,
                              IHostingEnvironment env,
                              UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager
                              )
        {
            _context = context;
            _roleManager = roleManager;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> AnaSəhifə()
        {
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

            ViewBag.Home = "Home";
            ViewBag.Regions = _context.Regions.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.ProperyCategories = _context.PropertyCategorys.ToList();
            ViewBag.Rooms = _context.Room.ToList();

            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList(),
            };

            return View(model);
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
        
        public async Task<IActionResult> Profilim()
        {
            ApplicationUser OnlineUser = await _userManager.FindByNameAsync(User.Identity.Name);


                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.ApplicationUserId == OnlineUser.Id),
                    User = OnlineUser
                };

                return View(model);

        }

        public async Task<IActionResult> OfflineProfile(string id)
        {
            //ApplicationUser OnlineUser = await _userManager.FindByNameAsync(User.Identity.Name);
            //if (id == null || id == OnlineUser.Id)
            //{
            //    ViewModel model = new ViewModel()
            //    {
            //        Advertisements = _context.Advertisements.Where(x => x.ApplicationUserId == OnlineUser.Id),
            //        User = OnlineUser
            //    };

            //    return View(model);
            //}
            //else
            //{
                ApplicationUser offlineUser = await _userManager.FindByIdAsync(id);
               

                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.ApplicationUserId == offlineUser.Id),
                    User = offlineUser
                };

                return View(model);
            //}

            //return View();
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