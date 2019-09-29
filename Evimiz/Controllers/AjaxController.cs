using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
                    Advertisements = _context.Advertisements.Where(x => x.IsPremium == true && x.PropertyCategoryId == 1).OrderByDescending(x=>x.PublishDate),
                    Images = _context.Images.ToList()
                };
                
                return PartialView("_CheckedPartial", model);
            } 
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsPremium == true && x.PropertyCategoryId == 2).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == true && x.PropertyCategoryId == 1).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == true && x.PropertyCategoryId == 2).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium==false && x.PropertyCategoryId == 1).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId==1).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 1).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 2).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 2).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 3).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 3).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 4).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 4).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 5).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 5).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 6).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 6).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 7).OrderByDescending(x => x.PublishDate),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 7).OrderByDescending(x => x.PublishDate),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 8),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 8),
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
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 1 && x.CategoryId == 9),
                    Images = _context.Images.ToList()
                };

                return PartialView("_CheckedPartial", model);
            }
            else if (IsChecked == false)
            {
                ViewModel model = new ViewModel()
                {
                    Advertisements = _context.Advertisements.Where(x => x.IsVip == false && x.IsPremium == false && x.PropertyCategoryId == 2 && x.CategoryId == 9),
                    Images = _context.Images.ToList(),
                };

                return PartialView("_CheckedPartial", model);
            }

            return View();
        }
    }
}