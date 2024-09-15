using AspNetCore_WebApp_Mvc_Attribute.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCore_WebApp_Mvc_Attribute.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public string Index()
        {
            return "Index() Action Method of HomeController";
        }

        [Route("Home/Details/{id}")]
        public string Details(int id)
        {
            return "Details() Action Method of HomeController, ID Value = " + id;
        }

        [Route("Home/Details2/{id?}")] // with id is optional parameter
        public string Details2(int id)
        {
            return "Details() Action Method of HomeController, ID Value = " + id;
        }

        [Route("Home/Details3/{id=10}")] // with id is default 10
        public string Details3(int id)
        {
            return "Details() Action Method of HomeController, ID Value = " + id;
        }
    }
}
