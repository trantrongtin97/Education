using Microsoft.AspNetCore.Mvc;

namespace Attribute.Controllers
{
    [Route("Demohttp")]
    public class DemoHttpController : Controller
    {
        [HttpGet("")]
        [HttpGet("/")]
        [HttpGet("Index")]
        public string Index()
        {
            return "Index() Action Method of DemoHttpController";
        }
        [HttpGet("Details/{id?}")]
        public string Details(int id)
        {
            return "Details() Action Method of DemoHttpController, ID Value = " + id;
        }
        [HttpGet("~/About")]
        public string About(int id)
        {
            return "About() Action Method of DemoHttpController";
        }
    }
}
