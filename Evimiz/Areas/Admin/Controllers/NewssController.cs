using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewssController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly IHostingEnvironment _env;

        public NewssController(Db_Evimiz context,
                                IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet]
        public IActionResult NewsCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewsCreate(News news)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Boşluqları doldurun");
                return View(news);
            }

            if (news.Photo == null)
            {
                ModelState.AddModelError("Image", "Şəkil daxil edin");
                return View(news);
            }

            if (news.Photo.ContentType.Contains("image/"))
            {
                string folderPath = Path.Combine(_env.WebRootPath, "Images","News");
                string fileName = Guid.NewGuid().ToString() + "_" + news.Photo.FileName;
                string filePath = Path.Combine(folderPath, fileName);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await news.Photo.CopyToAsync(fileStream);
                }

                News newN = new News()
                {
                    ImageUrl = fileName,
                    Title = news.Title,
                    Info = news.Info,
                    PublishDate = DateTime.Now,
                    Author = news.Author,
                    ViewCount=1
                };

                _context.Newss.Add(newN);
                await _context.SaveChangesAsync();
            }

            TempData["CreateNew"] = true;
            return RedirectToAction("Xəbərlər", "Dashboard");
        }

        [HttpGet, ActionName("DeleteNew")]
        public async Task<IActionResult> DeleteNew(int? id)
        {
            if (id == null) return NotFound();

            News news = await _context.Newss.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpPost, ActionName("DeleteNew"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteNewPost(int? id)
        {
            if (id == null) return NotFound();

            News news = _context.Newss.Find(id);

            if (news == null) return NotFound();

            string currentFilePath = Path.Combine(_env.WebRootPath, "Image","News" ,news.ImageUrl);
            if (System.IO.File.Exists(currentFilePath))
            {
                System.IO.File.Delete(currentFilePath);
            }

            _context.Newss.Remove(news);
            await _context.SaveChangesAsync();

            return RedirectToAction("Xəbərlər", "Dashboard");
        }

        [HttpGet]
        public async Task<IActionResult> ViewNew(int? id)
        {
            if (id == null) return NotFound();

            News news = await _context.Newss.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpGet]
        [ActionName("UpdateNew")]
        public async Task<IActionResult> UpdateNewGet(int? id)
        {
            if (id == null) return NotFound();

            News news = await _context.Newss.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpPost, ActionName("UpdateNew"), ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateNewPost(int? id, News newsa)
        {
            if (id == null) return NotFound();

            News mainNewsFromDb = _context.Newss.Find(id);

            if (mainNewsFromDb == null) return NotFound();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please input valid properties");
                return View(newsa);
            }

            if (newsa.Photo != null)
            {
                if (newsa.Photo.ContentType.Contains("image/"))
                {
                    string folderPath = Path.Combine(_env.WebRootPath, "images","News");
                    string fileName = Guid.NewGuid().ToString() + "_" + newsa.Photo.FileName;
                    string filePath = Path.Combine(folderPath, fileName);

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await newsa.Photo.CopyToAsync(fileStream);
                    }

                    string currentFilePath = Path.Combine(_env.WebRootPath, "image", mainNewsFromDb.ImageUrl);
                    if (System.IO.File.Exists(currentFilePath))
                    {
                        System.IO.File.Delete(currentFilePath);
                    }

                    mainNewsFromDb.ImageUrl = fileName;
                }
            }

            mainNewsFromDb.Title = newsa.Title;
            mainNewsFromDb.Info = newsa.Info;
            mainNewsFromDb.PublishDate = DateTime.Now;
            mainNewsFromDb.Author = newsa.Author;

            await _context.SaveChangesAsync();
            TempData["UpdateNew"] = true;
            return RedirectToAction("NewsList", "Dashboard");
        }
    }
}