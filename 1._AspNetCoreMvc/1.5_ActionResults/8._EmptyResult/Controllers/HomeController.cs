using EmptyResult.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmptyResult.Controllers
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

        public IActionResult ProcessRequest()
        {
            // Perform some processing
            // Return an empty HTTP response
            return new Microsoft.AspNetCore.Mvc.EmptyResult();
        }

        public IActionResult DeleteResource()
        {
            // Delete the resource
            // Return a 204 No Content response with an EmptyResult
            return NoContent();
        }
    }
}
