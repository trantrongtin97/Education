using Microsoft.AspNetCore.Mvc;

namespace StatusResult.Controllers
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

        public IActionResult NotFoundExample()
        {
            return new StatusCodeResult(404);
            //return StatusCode(404);
            //return StatusCode(404, new { message = "Resource Not Found" });
            //return new NotFoundResult();
            //return NotFound();
            //return NotFound("Resource Not Found");
        }

        public IActionResult CustomStatusCodeExample()
        {
            return new StatusCodeResult(403);
            //return StatusCode(403);
            //return StatusCode(403, "Resource Not Found");
        }

        public IActionResult UnauthorizedExample()
        {
            return new UnauthorizedResult();
            //return Unauthorized();
            //return Unauthorized(new { Message = "You Have Not Access to This Page" });
        }

        public IActionResult OkExample()
        {
            return new OkResult();
            // return Ok(); 
        }
        public IActionResult OkExample2()
        {
            var data = new { Message = "Success" };
            // Returns a JSON object with a 200 OK response
            return Ok(data);
        }
    }
}
