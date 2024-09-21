using ObjectResult.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ObjectResult.Controllers
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

        public IActionResult GetPerson()
        {
            var person = new { FirstName = "Tran", LastName = "Tin", Age = 27 };
            // Return an ObjectResult with JSON serialization
            return new Microsoft.AspNetCore.Mvc.ObjectResult(person);
            // Or use the shorthand:
            // return Ok(person);
        }

        public IActionResult GetPerson2()
        {
            var person = new { FirstName = "Tran", LastName = "Tin", Age = 27 };
            var result = new Microsoft.AspNetCore.Mvc.ObjectResult(person)
            {
                StatusCode = 200, // HTTP status code
                ContentTypes = new Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection
                {
                    "application/json" // Content type(s)
                }
            };
            return result;
        }

        public IActionResult GetPerson3()
        {
            var person = new { FirstName = "Tran", LastName = "Tin", Age = 27 };
            // Return a 200 OK response with JSON serialization
            return Ok(person);
        }
    }
}
