using RedirectResult.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RedirectResult.Controllers
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

        public Microsoft.AspNetCore.Mvc.RedirectResult Index2()
        {
            return new Microsoft.AspNetCore.Mvc.RedirectResult("https://github.com/trantrongtin97");
        }

        public Microsoft.AspNetCore.Mvc.RedirectResult Index3()
        {
            return Redirect("https://github.com/trantrongtin97");
        }

        public Microsoft.AspNetCore.Mvc.RedirectResult Index4()
        {
            var redirectResult = new Microsoft.AspNetCore.Mvc.RedirectResult("https://github.com/trantrongtin97")
            {
                Permanent = false,
                PreserveMethod = true
            };
            return redirectResult;
        }

        public RedirectToRouteResult Index5()
        {
            return RedirectToRoute("AboutUsRoute");
        }

        public RedirectToRouteResult Index6()
        {
            return RedirectToRoute("AboutNameRoute", new { name = "3T" });
        }

        public RedirectToRouteResult Index7()
        {
            // Perform some logic
            // Redirect to a different route
            // You need to specify the Route Name, not the Route Pattern
            //return RedirectToRoute("AboutRoute", new { name = "Index" });
            return RedirectToRoute(new { controller = "Home", action = "AboutWithName", name = "TTTT" });
        }

        public RedirectToRouteResult Index8()
        {
            var routeValues = new { controller = "Home", action = "AboutWithAgeAndName", age = 27, name = "3T" };
            var redirectResult = new RedirectToRouteResult(
                routeName: null,          // No specific route name
                routeValues: routeValues, // Route values defined earlier
                permanent: false,         // Temporary redirection
                fragment: "AboutSection"  // URL fragment identifier
            );
            return redirectResult;
        }

        public RedirectToActionResult Index9()
        {
            // Perform Some Logic
            // Redirect to a different action within the same controller
            // Specifying the Controller name is Optional
            return RedirectToAction("About", "Home");
        }

        public RedirectToActionResult Index10()
        {
            // Perform Some Logic
            // Redirect to the About action with a Route Parameter
            //return RedirectToAction("About", new { id = 123 });
            // Redirect to the About action with a Route Parameter Id and a Query String Parameter name 
            return RedirectToAction("AboutWithAgeAndName", "Home", new { age = 27, name = "TTT" });
        }

        public RedirectToActionResult Index11()
        {
            var routeValues = new { age = 27, name = "TTT" };
            // Create a new instance of RedirectToActionResult
            // Specify the action name ("About"), controller name ("Home"), route values, 
            // and additional options (permanent and preserveMethod)
            var redirectResult = new RedirectToActionResult(
                actionName: "AboutWithAgeAndName",          // The action to redirect to
                controllerName: "Home",       // The controller to redirect to
                routeValues: routeValues,     // The route values to pass to the action
                permanent: false,             // Indicates if the redirect is permanent (HTTP 301)
                preserveMethod: true,         // Indicates if the HTTP method should be preserved
                fragment: "AboutSection"       //Indicates the URL Fragment, i.e., append in the URL as #AboutSection
            );
            return redirectResult;
        }

        public string About()
        {
            return "Hello, I am TTT";
        }

        public string AboutWithName(string name)
        {
            return $"Hello, I am {name}";
        }

        public string AboutWithAgeAndName(int age, string name)
        {
            return $"Hello, I am {name}, {age} Age";
        }
    }
}
