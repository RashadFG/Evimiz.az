using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ElanController : Controller
    {
        private readonly Db_Evimiz _context;
        public ElanController(Db_Evimiz context)
        {
            _context = context;
        }

        public IActionResult Təsdiqləmə(int id)
        {
            if (id == null) return NotFound();

            ViewModel model = new ViewModel()
            {
                Advertisement = _context.Advertisements.FirstOrDefault(ad => ad.Id == id),
                Advertisements = _context.Advertisements.Where(ad => ad.CategoryId == _context.Advertisements.FirstOrDefault(ada => ada.Id == id).CategoryId)
            };

            return View(model); 
        }

        public async Task<IActionResult> Sil(int id)
        {
            var Advertisement = await _context.Advertisements.FindAsync(id);
                Advertisement.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Advertisement","Dashboard","Admin");
        }

        public async  Task<IActionResult> Təsdiqlə(int id)
        {
            var Advertisement = await _context.Advertisements.FindAsync(id);
            Advertisement.IsConfirmed = true;

            await _context.SaveChangesAsync();
            return RedirectToAction("Advertisement", "Dashboard", "Admin");
        }

        public IActionResult Haqqinda(int? id)
        {
            if (id == null) return NotFound();

            ViewModel model = new ViewModel()
            {
                Advertisement = _context.Advertisements.FirstOrDefault(ad => ad.Id == id),
                Advertisements = _context.Advertisements.Where(ad => ad.CategoryId == _context.Advertisements.FirstOrDefault(ada => ada.Id == id).CategoryId)
            };

            return View(model);
        }
    }
}