using AspNetCore_WebApp_Mvc_CustomRouteConstraints.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCore_WebApp_Mvc_CustomRouteConstraints.Controllers
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

        public string Detail(string id)
        {
            return $"Details({id}) Action Method of HomeController";
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
