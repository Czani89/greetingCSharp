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
    public class NavigationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
