using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Controllers
{
    public class XəbərlərController : Controller
    {
        [ActionName("Haqqında")]
        public IActionResult About()
        {
            return View();
        }
    }
}