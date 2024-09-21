using JsonResult.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace JsonResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public Microsoft.AspNetCore.Mvc.JsonResult Index()
        {
            var jsonData = new
            {
                Name = "TTT",
                ID = 4,
                DateOfBirth = new DateTime(1997, 07, 11)
            };
            return new Microsoft.AspNetCore.Mvc.JsonResult(jsonData);
        }

        public Microsoft.AspNetCore.Mvc.JsonResult Index2()
        {
            var jsonArray = new[]
            {
                new { Name = "3T", Age = 25, Occupation = "Dev2" },
                new { Name = "4T", Age = 30, Occupation = "Manager2" }
            };
            return Json(jsonArray);
        }

        public IActionResult Index3()
        {
            var jsonArray = new[]
            {
                new { Name = "TTTT", Age = 25, Occupation = "Dev3" },
                new { Name = "TranTin", Age = 30, Occupation = "Manager3" }
            };
            return Ok(jsonArray); // This will be automatically serialized to JSON
        }

        public Microsoft.AspNetCore.Mvc.JsonResult Index4()
        {
            // Create a new instance of JsonSerializerOptions
            var options = new JsonSerializerOptions
            {
                // Property names will remain as defined in the class
                PropertyNamingPolicy = null,
                // JSON will be formatted with indents for readability
                WriteIndented = true,
                // Properties with null values will be ignored
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                // Read-only properties will be ignored during serialization
                IgnoreReadOnlyProperties = true,
            };
            // Create a list of Employee objects with sample data
            var jsonArray = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "TranTin", Age = 25, Occupation = "Dev4", Address = "TTT" },
                new Employee() { Id = 2, FirstName = "TinTran", Age = 30, Occupation = "Manager4" }
            };
            // Return the list as a JSON result, using the specified JsonSerializerOptions
            return Json(jsonArray, options);
        }

        public ActionResult GoToDetails()
        {
            return View("Index");
        }

        public ActionResult Details()
        {
            var options = new JsonSerializerOptions()
            {
                // Property names will remain as defined in the class
                PropertyNamingPolicy = null,
                // JSON will be formatted with indents for readability
                WriteIndented = true,
            };

            try
            {
                //Based on the Category Fetch the Data from the database 
                //Here, we have hard coded the data
                List<Employee> products = new List<Employee>
                {
                    new Employee{ Id = 1, FirstName = "TranTin1", Age = 25, Occupation = "Dev1", Address = "TTT1" },
                    new Employee{ Id = 2, FirstName = "TranTin2", Age = 25, Occupation = "Dev2", Address = "TTT2" },
                    new Employee{ Id = 3, FirstName = "TranTin3", Age = 25, Occupation = "Dev3", Address = "TTT3" }
                };
                return Json(products, options);
            }
            catch (Exception ex)
            {
                var errorObject = new
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    ExceptionType = "Internal Server Error"
                };
                return new Microsoft.AspNetCore.Mvc.JsonResult(errorObject, options)
                {
                    StatusCode = StatusCodes.Status500InternalServerError 
                };
            }
        }
    }
}
