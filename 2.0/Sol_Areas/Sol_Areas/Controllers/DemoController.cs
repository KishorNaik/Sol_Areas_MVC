using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Areas.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RedirectToArea()
        {
            base.TempData["Data"] = "Hello Area";

            return RedirectToAction("Index", "Users", new { Area = "UserModule" });
        }
    }
}