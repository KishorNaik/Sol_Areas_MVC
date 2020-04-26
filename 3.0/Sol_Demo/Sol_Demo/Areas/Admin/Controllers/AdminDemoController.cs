using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Areas.Admin.Context;

namespace Sol_Demo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDemoController : Controller
    {
        private readonly IMessage message = null;

        public AdminDemoController(IMessage message)
        {
            this.message = message;
        }

        public IActionResult Index()
        {
            var value = TempData["Data"] as string;
            ViewBag.DataShow = value;

            var getString = message?.GetMessage();

            return View();
        }
    }
}