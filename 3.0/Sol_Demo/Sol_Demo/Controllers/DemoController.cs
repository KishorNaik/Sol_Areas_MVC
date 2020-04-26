using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OnAction()
        {
            return RedirectToAction("Index", "AdminDemo", new { Area = "Admin" });
        }

        [HttpGet]
        public IActionResult OnSendData()
        {
            TempData["Data"] = "Hello From Main Page";
            TempData.Keep();
            return RedirectToAction("Index", "AdminDemo", new { Area = "Admin" });
        }
    }
}