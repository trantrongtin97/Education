using AspNetCore_WebApp_Mvc_TempData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace AspNetCore_WebApp_Mvc_TempData.Controllers
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
            TempData["Name"] = "3T";
            TempData["Age"] = 27;

            //Retention of All keys of TempData for the next request
            //TempData.Keep();
            //Retention of Individual keys of TempData for the next request
            //TempData.Keep("Name");
            //TempData.Keep("Age");

            //var myObject = new object();
            //string json = JsonSerializer.Serialize(myObject);
            //TempData["MyObject"] = json;

            return View();
        }

        public IActionResult Privacy()
        {
            //Retention of Individual keys of TempData for the next request
            //TempData.Keep("Name");
            //TempData.Keep("Age");

            return View();
        }

        public IActionResult About()
        {
           
            //if (TempData.ContainsKey("Name"))
            //{
            //    //Peek Method will read the data and preserve the key for next request
            //    ViewData["Name"] = TempData.Peek("Name");
            //}
            //if (TempData.ContainsKey("Age"))
            //{
            //    //Peek Method will read the data and preserve the key for next request
            //    ViewData["Age"] = TempData.Peek("Age");
            //}
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
