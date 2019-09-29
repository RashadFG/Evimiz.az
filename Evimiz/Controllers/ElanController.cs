using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Controllers
{
    public class ElanController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly UserManager<İstifadəçi> _usermanager;
        private readonly IHostingEnvironment _env;

        public ElanController(Db_Evimiz context, UserManager<İstifadəçi> usermanager, IHostingEnvironment env)
        {
            _context = context;
            _usermanager = usermanager;
            _env = env;
        }

        [ActionName("Yarat")]
        public IActionResult Create()
        {
            ViewBag.PropertyCategories = _context.PropertyCategorys.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.PropertyRepairs = _context.PropertyRepairs.ToList();
            ViewBag.PropertyDocuments = _context.PropertyDocuments.ToList();
            ViewBag.NumberKeyCodeOnes = _context.NumberKeyCodes.ToList();
            ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();
            ViewBag.City = _context.Cities.ToList();
            ViewBag.Regions = _context.Regions.ToList();
            ViewBag.Metros = _context.Metros.ToList();
            ViewBag.Villages = _context.Villages.ToList();
            ViewBag.Rents = _context.Rents.ToList();
            ViewBag.Rooms = _context.Room.ToList();
            ViewBag.Floors = _context.Floors.ToList();
            ViewBag.Ranks = _context.Ranks.ToList();


            return View();
        }
        [HttpPost,ActionName("Yarat")]
        public async Task<IActionResult> Create(Advertisement advertisement)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.PropertyCategories = _context.PropertyCategorys.ToList();
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.PropertyRepairs = _context.PropertyRepairs.ToList();
                ViewBag.PropertyDocuments = _context.PropertyDocuments.ToList();
                ViewBag.NumberKeyCodeOnes = _context.NumberKeyCodes.ToList();
                ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();
                ViewBag.City = _context.Cities.ToList();
                ViewBag.Regions = _context.Regions.ToList();
                ViewBag.Metros = _context.Metros.ToList();
                ViewBag.Villages = _context.Villages.ToList();
                ViewBag.Rents = _context.Rents.ToList();
                ViewBag.Rooms = _context.Room.ToList();
                ViewBag.Floors = _context.Floors.ToList();
                ViewBag.Ranks = _context.Ranks.ToList();

                ModelState.AddModelError("", "Please input valid properties");
                return View(advertisement);
            }

            İstifadəçi user = await _usermanager.FindByNameAsync(User.Identity.Name);

            Advertisement ad = new Advertisement()
            {
                PropertyCategoryId = advertisement.PropertyCategoryId,
                CategoryId = advertisement.CategoryId,
                Area = advertisement.Area,
                Price = advertisement.Price,
                About = advertisement.About,
                PropertyRepairId = advertisement.PropertyRepairId,
                PropertyDocumentId = advertisement.PropertyDocumentId,
                PublishDate = DateTime.Now,
                Address = advertisement.Address,
                NumberKeyCodeId = advertisement.NumberKeyCodeId,
                NumberKeyCodeSecondId = advertisement.NumberKeyCodeSecondId,
                FirstPhoneNumber = advertisement.FirstPhoneNumber,
                SecondPhoneNumber = advertisement.SecondPhoneNumber,
                İstifadəçiId = user.Id,
                CityId = advertisement.CityId,
                RegionId = advertisement.RegionId,
                MetroId = advertisement.MetroId,
                VillageId = advertisement.VillageId,
                RentId = advertisement.RentId,
                RoomId=advertisement.RoomId,
                FloorId=advertisement.FloorId,
                RankId=advertisement.RankId
            };

            await _context.Advertisements.AddAsync(ad);

            foreach (var Pho in advertisement.AllPhotos)
            {
                if (Pho != null)
                {
                    if (Pho.ContentType.Contains("image/"))
                    {
                        string folderPathAll = Path.Combine(_env.WebRootPath, "Images", "Advertisement");
                        string fileNameAll = Guid.NewGuid().ToString() + "_" + Pho.FileName;
                        string filePathAll = Path.Combine(folderPathAll, fileNameAll);

                        using (FileStream fileStream = new FileStream(filePathAll, FileMode.Create))
                        {
                            await Pho.CopyToAsync(fileStream);
                        }

                        Image img = new Image()
                        {
                            AdvertisementId = ad.Id,
                            Name = fileNameAll,
                        };

                        await _context.Images.AddAsync(img);
                    }
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("AnaSəhifə", "Evimiz");
        }

        public IActionResult Haqqında(int? id)
        {
            if (id == null) return NotFound();

            ViewModel model = new ViewModel()
            {
                Advertisement = _context.Advertisements.FirstOrDefault(ad => ad.Id == id),
                Advertisements = _context.Advertisements.Where(ad => ad.CategoryId == _context.Advertisements.FirstOrDefault(ada => ada.Id == id).CategoryId)
            };

            return View(model);
        }

        public IActionResult DüzəlişEt()
        {
            ViewBag.Edit = "DüzəlişEt";
            return View();
        }

        public IActionResult AllPremium()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };

            return View(model);
        }

        public IActionResult AllVip()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllUsual()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };

            return View(model);
        }

        public IActionResult AllNewPlace()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };

            return View(model);
        }

        public IActionResult AllOldPlace()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };

            return View(model);
        }

        public IActionResult AllVilla()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllHouse()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllYardHouse()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllOffice()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllPropertyObject()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllGrarage()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }

        public IActionResult AllPlace()
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.ToList(),
                Images = _context.Images.ToList(),
                Users = _context.Users.ToList()
            };
            return View(model);
        }
    }
}