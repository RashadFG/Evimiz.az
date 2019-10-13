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
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly IHostingEnvironment _env;

        public ElanController(Db_Evimiz context, 
                              UserManager<ApplicationUser> usermanager, 
                              IHostingEnvironment env)
        {
            _context = context;
            _usermanager = usermanager;
            _env = env;
        }

        [ActionName("Yarat")]
        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("DaxilOl", "Hesab");
            }
            else
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

            ApplicationUser user = await _usermanager.FindByNameAsync(User.Identity.Name);

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
                ApplicationUserId = user.Id,
                CityId = advertisement.CityId,
                RegionId = advertisement.RegionId,
                MetroId = advertisement.MetroId,
                VillageId = advertisement.VillageId,
                RentId = advertisement.RentId,
                RoomId=advertisement.RoomId,
                FloorId=advertisement.FloorId,
                RankId=advertisement.RankId,
                IsPremium=advertisement.IsPremium,
                IsVip=advertisement.IsVip,
            };

            await _context.Advertisements.AddAsync(ad);
            bool isMain = true;
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
                        if (isMain == true)
                        {
                            img.IsMainPhoto =true;
                        }
                        isMain = false;
                        await _context.Images.AddAsync(img);
                    }
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("AnaSəhifə", "Evimiz");
        }

        [HttpGet]
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

        [HttpGet]
        public async Task<IActionResult> Sil(int? id)
        {
            if (id == null) return NotFound();
            Advertisement ada = _context.Advertisements.FirstOrDefault(ad => ad.Id == id);
            if (ada == null) return NotFound();

            ViewModel model = new ViewModel()
            {
                Advertisement= ada,
            };

            return View(model);
        }

        [HttpPost,ActionName("Sil")]
        public async Task<IActionResult> Sildi(int? id)
        {
            if (id == null) return NotFound();

            Advertisement ada = _context.Advertisements.Find(id);
            ;
            if (ada == null) return NotFound();

            foreach (var item in _context.Images.Where(x => x.AdvertisementId == ada.Id))
            {
                string currentFilePath = Path.Combine(_env.WebRootPath, "Images", "Advertisement" ,item.Name);
                if (System.IO.File.Exists(currentFilePath))
                {
                    System.IO.File.Delete(currentFilePath);
                }
            }

            _context.Advertisements.Remove(ada);
            await _context.SaveChangesAsync();

            return RedirectToAction("Profilim", "Evimiz");
        }

        [HttpGet]
        public IActionResult DüzəlişEt(int? id)
        {
            ViewBag.Edit = "DüzəlişEt";

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

            if (id == null) return NotFound();

            ViewModel model = new ViewModel()
            {
                Advertisement = _context.Advertisements.FirstOrDefault(ad => ad.Id == id),
                Images = _context.Images.Where(x => x.AdvertisementId == id),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DüzəlişEt(int? id, Advertisement advertisement)
        {
            ViewModel model = new ViewModel()
            {
                Advertisement = _context.Advertisements.FirstOrDefault(ad => ad.Id == id),
                Images = _context.Images.Where(x => x.AdvertisementId == id)
            };

            Advertisement mainAdvertisementFromDb = _context.Advertisements.Find(id);
            ApplicationUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            advertisement.ApplicationUserId = user.Id;

            if (!ModelState.IsValid)
            {
                #region ViewBags
                ViewBag.Edit = "DüzəlişEt";

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
                #endregion

                ModelState.AddModelError("", "Düzgun dəyətlər daxil edin");
                return View(model);
            }

            if (user == null || mainAdvertisementFromDb.ApplicationUserId != user.Id)
            {
                #region ViewBags
                ViewBag.Edit = "DüzəlişEt";

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
                #endregion

                ModelState.AddModelError("", "Aktiv istifadəçi kimi daxil olun");
                return View(model);
            }

            #region ViewBags
            ViewBag.Edit = "DüzəlişEt";

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
            #endregion

            if (id == null) return NotFound();

            if (mainAdvertisementFromDb == null) return NotFound();

            if (advertisement.AllPhotos != null)
            {
                foreach (var Pho in advertisement.AllPhotos)
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
                            AdvertisementId = model.Advertisement.Id,
                            Name = fileNameAll
                        };

                        _context.Images.Add(img);

                    }
                }
            }

            mainAdvertisementFromDb.About = advertisement.About;
            mainAdvertisementFromDb.Address = advertisement.Address;
            mainAdvertisementFromDb.Area = advertisement.Area;
            mainAdvertisementFromDb.PublishDate = DateTime.Now;
            mainAdvertisementFromDb.CategoryId = advertisement.CategoryId;
            mainAdvertisementFromDb.Price = advertisement.Price;
            mainAdvertisementFromDb.CityId = advertisement.CityId;
            mainAdvertisementFromDb.PropertyCategoryId = advertisement.PropertyCategoryId;
            mainAdvertisementFromDb.PropertyRepairId = advertisement.PropertyRepairId;
            mainAdvertisementFromDb.RankId = advertisement.RankId;
            mainAdvertisementFromDb.CityId = advertisement.CityId;

            mainAdvertisementFromDb.RoomId = advertisement.RoomId;
            mainAdvertisementFromDb.FloorId = advertisement.FloorId;
            mainAdvertisementFromDb.FloorId = advertisement.FloorId;
            mainAdvertisementFromDb.Area = advertisement.Area;

            if (advertisement.RankId != null)
            {
                mainAdvertisementFromDb.RankId = advertisement.RankId;
            }

            mainAdvertisementFromDb.RentId = advertisement.RentId;

            mainAdvertisementFromDb.PropertyDocumentId = advertisement.PropertyDocumentId;
            mainAdvertisementFromDb.NumberKeyCodeId = advertisement.NumberKeyCodeId;
            mainAdvertisementFromDb.FirstPhoneNumber = advertisement.FirstPhoneNumber;
            mainAdvertisementFromDb.NumberKeyCodeSecondId = advertisement.NumberKeyCodeSecondId;
            mainAdvertisementFromDb.SecondPhoneNumber = advertisement.SecondPhoneNumber;

            mainAdvertisementFromDb.IsPremium = advertisement.IsPremium;
            mainAdvertisementFromDb.IsVip = advertisement.IsVip;

            if (mainAdvertisementFromDb.CityId == 10)
            {
                if (advertisement.RegionId != null && advertisement.VillageId != null && advertisement.MetroId != null)
                {
                    mainAdvertisementFromDb.RegionId = advertisement.RegionId;
                    mainAdvertisementFromDb.VillageId = advertisement.VillageId;
                    mainAdvertisementFromDb.MetroId = advertisement.MetroId;
                }
                else
                {
                    #region ViewBags
                    ViewBag.Edit = "DüzəlişEt";

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
                    #endregion
                    ModelState.AddModelError("", "Elanin Bakıda harda yeləşməsini  daxil edin");
                    return View(model);
                }
            }

            if (advertisement.CityId == 10)
            {
                if (advertisement.RegionId != 0 && advertisement.VillageId != 0 && advertisement.MetroId != 0)
                {
                    mainAdvertisementFromDb.RegionId = advertisement.RegionId;
                    mainAdvertisementFromDb.VillageId = advertisement.VillageId;
                    mainAdvertisementFromDb.MetroId = advertisement.MetroId;
                    //return Content()
                }
                else
                {
                    #region ViewBags
                    ViewBag.Edit = "DüzəlişEt";

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
                    #endregion
                    ModelState.AddModelError("", "Elanin Bakıda harda yeləşməsini  daxil edin");
                    return View(model);
                }
            }

            //if (mainAdvertisementFromDb.VillageId != null)
            //{
            //    mainAdvertisementFromDb.VillageId = advertisement.VillageId;
            //}
            //else
            //{
            //    #region ViewBags
            //    ViewBag.Edit = "DüzəlişEt";

            //    ViewBag.PropertyCategories = _context.PropertyCategorys.ToList();
            //    ViewBag.Categories = _context.Categories.ToList();
            //    ViewBag.PropertyRepairs = _context.PropertyRepairs.ToList();
            //    ViewBag.PropertyDocuments = _context.PropertyDocuments.ToList();
            //    ViewBag.NumberKeyCodeOnes = _context.NumberKeyCodes.ToList();
            //    ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();
            //    ViewBag.City = _context.Cities.ToList();
            //    ViewBag.Regions = _context.Regions.ToList();
            //    ViewBag.Metros = _context.Metros.ToList();
            //    ViewBag.Villages = _context.Villages.ToList();
            //    ViewBag.Rents = _context.Rents.ToList();
            //    ViewBag.Rooms = _context.Room.ToList();
            //    ViewBag.Floors = _context.Floors.ToList();
            //    ViewBag.Ranks = _context.Ranks.ToList();
            //    #endregion
            //    ModelState.AddModelError("", "Qəsəbəni daxil edin");
            //    return View(model);
            //}

            //if (mainAdvertisementFromDb.MetroId != null)
            //{
            //    mainAdvertisementFromDb.MetroId = advertisement.MetroId;
            //}
            //else
            //{
            //    #region ViewBags
            //    ViewBag.Edit = "DüzəlişEt";

            //    ViewBag.PropertyCategories = _context.PropertyCategorys.ToList();
            //    ViewBag.Categories = _context.Categories.ToList();
            //    ViewBag.PropertyRepairs = _context.PropertyRepairs.ToList();
            //    ViewBag.PropertyDocuments = _context.PropertyDocuments.ToList();
            //    ViewBag.NumberKeyCodeOnes = _context.NumberKeyCodes.ToList();
            //    ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();
            //    ViewBag.City = _context.Cities.ToList();
            //    ViewBag.Regions = _context.Regions.ToList();
            //    ViewBag.Metros = _context.Metros.ToList();
            //    ViewBag.Villages = _context.Villages.ToList();
            //    ViewBag.Rents = _context.Rents.ToList();
            //    ViewBag.Rooms = _context.Room.ToList();
            //    ViewBag.Floors = _context.Floors.ToList();
            //    ViewBag.Ranks = _context.Ranks.ToList();
            //    #endregion
            //    ModelState.AddModelError("", "Metronu daxil edin");
            //    return View(model);
            //}




            await _context.SaveChangesAsync();

            return RedirectToAction("AnaSəhifə", "Evimiz");
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

