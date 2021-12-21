using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserRegistrationFormLab.Models;

namespace UserRegistrationFormLab.Controllers
{
    public class HomeController : Controller
    {
        public static string username = "";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View();
        }
        public IActionResult FormResponse(string first, string last, string email, string username, string password)
        {
            ViewBag.first = first;
            ViewBag.last = last;
            ViewBag.email = email;
            ViewBag.username = username;
            ViewBag.password = password;
            HomeController.username = $"Hola {username}!";
            return View();
        }

        public IActionResult Privacy()
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
