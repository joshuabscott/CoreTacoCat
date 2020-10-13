using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreTacoCat.Models;

namespace CoreTacoCat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Solve()
        {
            return View();
        }

        public IActionResult Code()
        {
            return View();
        }

        public IActionResult Git()
        {
            return View();
        }

        public IActionResult Portfoilio()
        {
            return View();


        }

        [HttpPost]
        public IActionResult Solve(string theWorld)
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
