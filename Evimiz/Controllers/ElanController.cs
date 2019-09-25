using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Controllers
{
    public class ElanController : Controller
    {
        [ActionName("Yarat")]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Haqqında ()
        {
            return View();
        }

        public IActionResult DüzəlişEt()
        {
            ViewBag.Edit = "DüzəlişEt";
            return View();
        }
    }
}