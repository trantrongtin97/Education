using Microsoft.AspNetCore.Mvc;

namespace B._AspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Index action from MVC Controller";
        }
    }
}
