using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using greeting.Models;

namespace greeting.Controllers
{

    public class HomeController : Controller
    {
        Greet greetCall = new Greet();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["Counter"] = greetCall.myCounter();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendToController(string name, string greeting)
        {
            greetCall.GreetMe(name, greeting);
            TempData["ErrorMessage"] = greetCall.ErrorMessage;
            TempData["GreetMessage"] = greetCall.GreetMessage;
            
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
