using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Areas.Areas.AdminModule.Controllers
{
    [Area("AdminModule")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}