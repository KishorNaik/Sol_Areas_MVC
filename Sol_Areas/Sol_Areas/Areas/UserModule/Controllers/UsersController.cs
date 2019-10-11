using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Areas.Areas.UserModule.Controllers
{
    [Area("UserModule")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            string data = TempData["Data"] as string;

            return View();
        }
    }
}