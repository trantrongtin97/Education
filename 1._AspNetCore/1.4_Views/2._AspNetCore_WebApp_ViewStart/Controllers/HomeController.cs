using _2._AspNetCore_WebApp_ViewStart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2._AspNetCore_WebApp_ViewStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
