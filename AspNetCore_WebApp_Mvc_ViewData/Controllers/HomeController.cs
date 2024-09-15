using AspNetCore_WebApp_Mvc_ViewData_ViewBag_StronglyTyped.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCore_WebApp_Mvc_ViewData_ViewBag_StronglyTyped.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult GetDetailViewData()
        {
            ViewData["Title"] = "Home Details Page - ViewData";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                Id = 1114,
                Name = "TTT"
            };
            ViewData["Student"] = student;
            return View("DetailViewData");
        }

        public ViewResult GetDetailViewBag()
        {
            ViewBag.Title = "Home Details Page - ViewBag";
            ViewBag.Header = "Student Details";
            Student student = new Student()
            {
                Id = 101,
                Name = "TTTT",
            };
            ViewBag.Student = student;
            return View("DetailViewBag");
        }

        public ViewResult TryViewDataToViewBag()
        {
            // Setup Data like ViewData
            ViewData["Title"] = "Home Details Page - ViewData";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                Id = 1114,
                Name = "TTT"
            };
            ViewData["Student"] = student;
            // Trans Data to View of ViewBag
            return View("DetailViewBag");
        }

        public ViewResult TryViewBagToViewData()
        {
            // Setup Data like ViewBag
            ViewBag.Title = "Home Details Page - ViewBag";
            ViewBag.Header = "Student Details";
            Student student = new Student()
            {
                Id = 101,
                Name = "TTTT",
            };
            ViewBag.Student = student;
            // Trans Data to View of ViewData
            return View("DetailViewData");
        }

        public ViewResult GetDetailStrongLyTyped()
        {
            ViewBag.Title = "Home Details Page - Strongly Typed";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                Id = 117,
                Name = "3T",
            };
            return View("DetailStrongLyTyped",student);
        }

    }
}
