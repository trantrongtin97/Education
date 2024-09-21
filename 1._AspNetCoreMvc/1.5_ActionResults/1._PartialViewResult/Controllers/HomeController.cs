using Microsoft.AspNetCore.Mvc;
using PartialViewResult.Attributes;
using PartialViewResult.Models;

namespace PartialViewResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public Microsoft.AspNetCore.Mvc.PartialViewResult Index()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Test",
            };
            return PartialView("_ProductDetailsPartialView", product);
        }

        public IActionResult Index2()
        {
            return View();
        }

        //Using attribute to block request GET and POST
        [AjaxOnly]
        public Microsoft.AspNetCore.Mvc.PartialViewResult UsingOnlyWithAJAX1(int productId)
        {
            Product product = new Product()
            {
                Id = productId,
                Name = "UsingOnlyWithAJAX1",
            };
            return PartialView("_ProductDetailsPartialView", product);
        }


        public Microsoft.AspNetCore.Mvc.PartialViewResult UsingOnlyWithAJAX2(int productId)
        {
            // Get the HTTP method of the current request (e.g., GET, POST)
            string method = HttpContext.Request.Method;
            // Get the value of the "X-Requested-With" header from the current request
            string? requestedWith = HttpContext?.Request?.Headers.XRequestedWith;
            // Check if the HTTP method is either POST or GET
            if (method == "POST" || method == "GET")
            {
                // Check if the request was made via AJAX (i.e., the "X-Requested-With" header is "XMLHttpRequest")
                if (requestedWith == "XMLHttpRequest")
                {
                    // Create a new Product object with the provided ProductId and a sample name
                    Product product = new Product()
                    {
                        Id = productId,
                        Name = "UsingOnlyWithAJAX2",
                    };
                    // Return the partial view "_ProductDetailsPartialView" with the product model
                    return PartialView("_ProductDetailsPartialView", product);
                }
            }
            // If the request is not valid (not an AJAX request), return the "_InvalidRequestPartialView" partial view
            return PartialView("_InvalidRequestPartialView");
        }
    }
}
