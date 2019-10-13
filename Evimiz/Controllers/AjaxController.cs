using Evimiz.DAL;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Evimiz.Controllers
{
    public class AjaxController : Controller
    {
        private readonly Db_Evimiz _context;

        public AjaxController(Db_Evimiz context)
        {
            _context = context;
        }

        public IActionResult Premium(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsPremium == true && x.PropertyCategoryId == 1).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsPremium == true && x.PropertyCategoryId == 2).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult VIP(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == true && x.PropertyCategoryId == 1).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == true && x.PropertyCategoryId == 2).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult Usual(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult NewPlace(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 1).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 1).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult OldPlace(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 2).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 2).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult Villa(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 3).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 3).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult House(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 4).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 4).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult YasrHouse(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 5).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 5).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult Office(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 6).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 6).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult Garage(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 7).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 7).OrderByDescending(x => x.PublishDate).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult Place(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 8).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 8).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public IActionResult PropertyOnject(bool IsChecked)
        {
            if (IsChecked == true)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 9).Take(16),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 9).Take(16),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }

        public void UploadPhoto(string src)
        {
            //if (advertisement.Photos != null)
            //{
            //    if (advertisement.Photos.ContentType.Contains("image/"))
            //    {
            //        string folderPath = Path.Combine(_env.WebRootPath, "image");
            //        string fileName = Guid.NewGuid().ToString() + "_" + advertisement.Photos.FileName;
            //        string filePath = Path.Combine(folderPath, fileName);

            //        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            //        {
            //            await advertisement.Photos.CopyToAsync(fileStream);
            //        }

            //        string currentFilePath = Path.Combine(_env.WebRootPath, "image", mainAdvertisementFromDb.ImageUrl);
            //        if (System.IO.File.Exists(currentFilePath))
            //        {
            //            System.IO.File.Delete(currentFilePath);
            //        }

            //        mainAdvertisementFromDb.ImageUrl = fileName;
            //    }
            //}
        }

        public IActionResult Search(int categoryId, int roomId, int regionId)
        {
            if (categoryId != 0 && roomId == 0)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.CategoryId == categoryId && x.RegionId == regionId),
                };
                return PartialView("_SearchPartial", model);
            }
            else if (roomId != 0 && categoryId == 0)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.RoomId == roomId && x.RegionId == regionId),
                };
                return PartialView("_SearchPartial", model);
            }
            else if (categoryId != 0 && roomId != 0)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.CategoryId == categoryId && x.RoomId == roomId && x.RegionId == regionId)
                };
                return PartialView("_SearchPartial", model);
            }
            else
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.RegionId == regionId)
                };
                return PartialView("_SearchPartial", model);
            }

        }

        public void DeleteSingleImageFromImageTable(int? id)
        {
            //if (id == null) return View("Views/Evimiz/Error.cshtml");
            var image = _context.Images.Find(id);
            _context.Images.Remove(image);
            _context.SaveChanges();
        }

        public void ChangeMainSingleImageFromImageTable(int? id)
        {
            //var activeImage = _context.Images.FirstOrDefault(x=>x.Id==activeId);
            var image = _context.Images.Find(id);
            foreach (var item in _context.Images.Where(x => x.AdvertisementId == image.AdvertisementId))
            {
                item.IsMainPhoto = false;
            }

            image.IsMainPhoto = true;
            _context.SaveChanges();
        }

        public IActionResult LoadMore(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == true).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreVip(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsVip == true).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreUsual(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreNewPlace(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId==1).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreOldPlace(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 2).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreOffice(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 6).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreVilla(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 3).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreYasrHouse(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 5).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreVHouse(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 4).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMorePropertyOnject(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 9).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreGarage(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.CategoryId == 7 && x.IsPremium == false && x.IsVip == false).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMorePlace(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.CategoryId == 8 && x.IsPremium == false && x.IsVip == false).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };
            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreUnconfirmed(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsConfirmed == false).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };

            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreProfile(int skip, string UserIdForAdvertisement)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.ApplicationUserId == UserIdForAdvertisement).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };

            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreConfirmed(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsConfirmed == true ).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };

            return PartialView("_CheckedPartial", model);
        }

        public IActionResult LoadMoreDeleted(int skip)
        {
            ViewModel model = new ViewModel()
            {
                Advertisements = _context.Advertisements.Where(x => x.IsDeleted == true).Skip(skip).Take(4),
                Images = _context.Images.ToList()
            };

            return PartialView("_CheckedPartial", model);
        }
    }
}